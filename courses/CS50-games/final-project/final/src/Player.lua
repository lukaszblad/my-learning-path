--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

Player = Class{}

function Player:init(def)
    self.y = GROUND_HEIGHT - CHARACTER_HEIGHT
    self.x = def.position == 'left' and LEFT_SIDE_X or RIGHT_SIDE_X
    self.side = def.position
    self.stateMachine = def.stateMachine
end

function Player:update(dt)
    self.stateMachine:update(dt)
end

function Player:changeState(state)
    self.stateMachine:change(state)
end

function Player:render()
    self.stateMachine:render()
end
