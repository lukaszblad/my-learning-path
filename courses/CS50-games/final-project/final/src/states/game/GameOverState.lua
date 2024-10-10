--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

GameOverState = Class{__includes = BaseState}

function GameOverState:enter(params)
    self.player = params.player
    self.woodBlocks = params.woodBlocks
    self.background = params.background
    self.score = params.score
end

function GameOverState:init()
    self.buttons = {}
    for button, parameters in pairs(GUI_DEFS.gameOverButtons) do
        buttonObject = MenuButton(parameters)
        table.insert(self.buttons, buttonObject)
    end
    for i, button in pairs(self.buttons) do
        local buttonStartY = button.y
        Timer.tween(0.5, {
            [button] = {y = buttonStartY + 200}
        })
    end
end

function GameOverState:update(dt)
    if love.mouse.wasPressed(1) then
        local x, y = push:toGame(love.mouse.getPosition())
        for i, button in pairs(self.buttons) do
            button:checkCollision(x, y)
        end
    end
    
    local x, y = push:toGame(love.mouse.getPosition())
    for i, button in pairs(self.buttons) do
        button:update(dt)
    end
end

function GameOverState:render()
    self.background:render()
    for i, woodBlock in pairs(self.woodBlocks) do
        woodBlock:render()
    end
    self.player:render()
    for i, button in pairs(self.buttons) do
        button:render()
    end
    love.graphics.print(tostring('Score: ' .. self.score), 10, 10)
end
