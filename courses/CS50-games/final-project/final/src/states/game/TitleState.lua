--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

-- "Okayū Games"

TitleState = Class{__includes = BaseState}

function TitleState:enter(params)
    self.title = params.title
    self.nextState = params.nextState or 'menu'
    self.nextTitle = params.nextTitle or nil
end

function TitleState:init()
    self.fadeAlpha = 255/255
    Timer.tween(2, {
        [self] = {fadeAlpha = 0/255}
    })
    :finish(
        function()
            Timer.tween(2, {
                [self] = {fadeAlpha = 255/255}
            })
            :finish(
                function()
                    gStateMachine:change(self.nextState, {
                        title = self.nextTitle
                    })
                end
            )
        end
    )
end

function TitleState:update(dt)
end


function TitleState:render()
    -- title
    love.graphics.setFont(gFonts['title-large'])
    love.graphics.setColor(1, 1, 1, 1)
    love.graphics.printf(self.title, 0, 100, VIRTUAL_WIDTH, 'center')
    -- fade rectangle
    love.graphics.setColor(0, 0, 0, self.fadeAlpha)
    love.graphics.rectangle('fill', 0, 0, VIRTUAL_WIDTH, VIRTUAL_HEIGHT)

    -- printState(self.title, 0)
end

