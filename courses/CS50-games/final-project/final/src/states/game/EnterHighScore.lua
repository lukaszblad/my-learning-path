--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

EnterHighScore = Class{__includes = BaseState}

function EnterHighScore:enter(params)
    self.indexToChange = params.index
    self.newScore = params.playerScore
    self.scores = params.scoresTable
end

function replaceCharAt(s, index, replacement)
    return string.sub(s, 1, index - 1) .. replacement .. string.sub(s, index + 1)
end

function EnterHighScore:init()
    self.background = Background(math.random(1))
    self.string = '---'
    self.y = VIRTUAL_HEIGHT / 2 - 16
    self.counter = 1
end

function EnterHighScore:update()
    if love.keyboard.keysTable[1] then
        -- if string.byte(love.keyboard.keysTable[1]) >= 65 and string.byte(love.keyboard.keysTable[1]) <= 90 then
            if self.counter == 1 then
                self.string = tostring(love.keyboard.keysTable[1]) .. string.sub(self.string, 2)
            elseif self.counter == 2 then
                self.string = string.sub(self.string, 1, 1) .. tostring(love.keyboard.keysTable[1]) .. string.sub(self.string, 3)
            elseif self.counter == 3 then
                self.string = string.sub(self.string, 1, 2) .. tostring(love.keyboard.keysTable[1])
                local scoresString = ''
                for i, score in pairs(self.scores) do
                    if self.indexToChange == i then
                        score.points = self.newScore
                        score.name = self.string
                    end
                    scoresString = scoresString .. score.name .. tostring(score.points) .. '\n'
                end
                love.filesystem.write('scores.lst', scoresString)
                gStateMachine:change('scores')
            end
            self.counter = self.counter + 1
        -- end
    end
end

function EnterHighScore:render()
    self.background:render()
    love.graphics.setFont(gFonts['pixel-medium'])
    love.graphics.setColor(1, 1, 1, 1)
    love.graphics.printf("ENTER HIGH SCORE", 0, self.y - 32, VIRTUAL_WIDTH, 'center')
    love.graphics.printf(tostring(self.string .. " .................. " .. self.newScore), 0, self.y, VIRTUAL_WIDTH, 'center')
end
