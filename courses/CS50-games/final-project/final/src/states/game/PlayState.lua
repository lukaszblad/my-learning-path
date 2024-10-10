--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

PlayState = Class{__includes = BaseState}

function PlayState:addBlock()
    local lastBlock = self.woodBlocks[#self.woodBlocks]
    table.insert(self.woodBlocks, WoodBlock(lastBlock.y - WOOD_BLOCK_SIZE, lastBlock.branchSide))
end

function PlayState:shiftBlocks()
    self:addBlock(self.woodBlocks)
    table.remove(self.woodBlocks, 1)

    for i, woodBlock in pairs(self.woodBlocks) do
        local destination = woodBlock.y + WOOD_BLOCK_SIZE
        Timer.tween(0.07, {
            [woodBlock] = {y = destination}
        })
    end
end

function PlayState:init()
    self.woodBlocks = {}
    table.insert(self.woodBlocks, WoodBlock(GROUND_HEIGHT - WOOD_BLOCK_SIZE, 'none'))
    for i = 1, 6, 1 do
        self:addBlock(self.woodBlocks)
    end
    self.player = Player({
        stateMachine = StateMachine {
            ['idle'] = function() return PlayerIdleState(self.player) end,
            ['chopping'] = function() return PlayerChoppingState(self.player) end,
        },
        position = self.woodBlocks[1].branchSide == 'left' and 'right' or 'left'
    })
    self.player:changeState('idle')
    self.background = Background(math.random(1))
    self.score = 0
    self.timeLeft = 100
    Timer.every(1,
        function()
            self.timeLeft = self.timeLeft - 10
        end
    )
    self.highScores = loadScores()
end

function PlayState:checkHighscore()
    for i, score in pairs(self.highScores) do
        if self.score > score.points then
            return gStateMachine:change('high-score', {
                index = i,
                playerScore = self.score,
                scoresTable = self.highScores,
            })
        end
    end
    return gStateMachine:change('game-over', {
        player = self.player,
        woodBlocks = self.woodBlocks,
        background = self.background,
        score = self.score
    })
end

function PlayState:checkCollision(direction)

    if direction == 'left' then
        self.player.side = 'left'
        self.player.x = LEFT_SIDE_X
    else
        self.player.side = 'right'
        self.player.x = RIGHT_SIDE_X
    end


    if self.woodBlocks[1].branchSide == direction then
        gSounds['hit']:play()
        self:checkHighscore()
    end

    if self.woodBlocks[2].branchSide == direction then
        self:shiftBlocks(self.woodBlocks)
        gSounds['hit']:play()
        self:checkHighscore()
    end

    gSounds['chop']:play()
    self:shiftBlocks(self.woodBlocks)
    self.score = self.score + 1
    self.timeLeft = self.timeLeft >= 100 and 100 or self.timeLeft + 2
end

function PlayState:update(dt)
    if self.timeLeft <= 0 then
        self:checkHighscore()
    end
    
    if love.keyboard.wasPressed('a') then
        self.player.stateMachine:change('chopping')
        self:checkCollision('left')
    elseif love.keyboard.wasPressed('d') then
        self.player.stateMachine:change('chopping')
        self:checkCollision('right')
    end

    self.background:update(dt)
    for i, woodBlock in pairs(self.woodBlocks) do
        woodBlock:update(dt)
    end
    self.player:update(dt)
end

function PlayState:render()
    self.background:render()
    for i, woodBlock in pairs(self.woodBlocks) do
        woodBlock:render()
    end
    self.player:render()
    -- score
    love.graphics.setFont(gFonts['pixel-small'])
    love.graphics.setColor(1, 1, 1, 1)
    love.graphics.print(tostring("Chopped wood: " .. self.score), 10, 10)
    love.graphics.setColor(0, 0, 0, 1)
    love.graphics.rectangle('fill', VIRTUAL_WIDTH - 110, 10, 100, 16)
    love.graphics.setColor(1, 0, 0, 1)
    love.graphics.rectangle('fill', VIRTUAL_WIDTH - 110, 10, self.timeLeft, 16)
end
