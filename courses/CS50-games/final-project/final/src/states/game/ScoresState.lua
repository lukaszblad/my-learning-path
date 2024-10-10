--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

ScoresState = Class{__includes = BaseState}

function ScoresState:init()
    self.background = Background(math.random(1))
    self.scores = loadScores()
end

function ScoresState:update(dt)
    if love.keyboard.wasPressed('backspace') then
        gStateMachine:change('menu')
    end
end

function ScoresState:render()
    self.background:render()
    love.graphics.setFont(gFonts['pixel-medium'])
    love.graphics.setColor(1, 1, 1, 1)
    for i, score in pairs(self.scores) do
        love.graphics.printf(tostring(score.name .. " .................. " .. score.points), 0, score.y, VIRTUAL_WIDTH, 'center')
    end
    love.graphics.setFont(gFonts['pixel-small'])
    love.graphics.printf("press BACKSPACE to return to menu", 0, VIRTUAL_HEIGHT - 30, VIRTUAL_WIDTH, 'center')
end
