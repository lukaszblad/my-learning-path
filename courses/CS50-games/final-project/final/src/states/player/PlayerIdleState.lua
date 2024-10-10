--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

PlayerIdleState = Class{__includes = BaseState}

function PlayerIdleState:init(player)
    self.player = player
    self.texture = PLAYER_DEFS.idleState[self.player.side]
end

function PlayerIdleState:update(dt)
end

function PlayerIdleState:render()
    love.graphics.draw(gTextures['characters'], gFrames['characters'][self.texture], self.player.x, self.player.y)
end
