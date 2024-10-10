--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

Background = Class{}

function Background:init(texture)
    self.texture = texture
end

function Background:update(dt)
end

function Background:render()
    love.graphics.draw(gTextures['backgrounds'], gFrames['backgrounds'][self.texture], 0, 0)
end
