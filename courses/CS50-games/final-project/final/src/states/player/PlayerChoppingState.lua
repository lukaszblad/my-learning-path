--[[
    GD50 Final Project
    50Force
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

PlayerChoppingState = Class{__includes = BaseState}

function PlayerChoppingState:init(player)
    self.player = player
    self.texture = PLAYER_DEFS.choppingState[self.player.side]
end

function PlayerChoppingState:update(dt)
    Timer.after(0.07,
        function()
            self.player.stateMachine:change('idle')
        end
    )
end

function PlayerChoppingState:render()
    love.graphics.draw(gTextures['characters'], gFrames['characters'][self.texture], self.player.x, self.player.y)
end
