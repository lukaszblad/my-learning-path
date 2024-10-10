--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

WoodBlock = Class{}

function WoodBlock:determineDirection(previousBlockDirection)
    local num = math.random(100)
    local direction = 'none'
    if num > 75 and previousBlockDirection ~= 'right' then
        direction = 'left'
    elseif num > 55 and previousBlockDirection ~= 'left' then
        direction = 'right'
    end
    return direction
end

function WoodBlock:init(y, previousDirection)
    self.branchSide = self:determineDirection(previousDirection)
    self.x = VIRTUAL_WIDTH / 2 - WOOD_BLOCK_SIZE / 2
    self.y = y
    self.texture = 1
end

function WoodBlock:update(dt)
end

function WoodBlock:render()
    if self.branchSide == 'right' then
        love.graphics.draw(gTextures['branches'], gFrames['branches'][2], self.x + WOOD_BLOCK_SIZE, self.y + WOOD_BLOCK_SIZE / 2 - 8)
    elseif self.branchSide == 'left' then
        love.graphics.draw(gTextures['branches'], gFrames['branches'][1], self.x - WOOD_BLOCK_SIZE, self.y + WOOD_BLOCK_SIZE / 2 - 8)
    end
    love.graphics.draw(gTextures['sprites'], gFrames['wood'][1], self.x, self.y)
end
