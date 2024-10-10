--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

MenuButton = Class{}

function MenuButton:init(parameters)
    self.name = parameters.name
    self.action = parameters.action
    self.texture = parameters.texture
    self.width = parameters.width
    self.height = parameters.height
    self.x = VIRTUAL_WIDTH / 2 - parameters.width / 2
    self.y = parameters.y
end

function MenuButton:update(dt)
end

function MenuButton:checkCollision(x, y)
    if x > self.x and x < self.x + self.width then
        if  y > self.y and y < self.y + self.height then
            gSounds['select']:play()
            gStateMachine:change(self.action)
        end
    end
end

function MenuButton:render()
    love.graphics.draw(gTextures['gui'], gFrames['gui'][self.texture], self.x, self.y)
end
