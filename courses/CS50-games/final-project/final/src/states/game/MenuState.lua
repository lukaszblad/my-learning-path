--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

MenuState = Class{__includes = BaseState}

function MenuState:init()
    self.buttons = {}
    self.background = Background(math.random(1))
    for button, parameters in pairs(GUI_DEFS.menuButtons) do
        buttonObject = MenuButton(parameters)
        table.insert(self.buttons, buttonObject)
    end
    gSounds['menu-music']:setLooping(true)
    gSounds['menu-music']:play()
    gSounds['menu-music']:setVolume(0.1)
end

function MenuState:update(dt)
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

function MenuState:render()
    self.background:render()
    for i, button in pairs(self.buttons) do
        button:render()
    end
    love.graphics.setFont(gFonts['large'])
    love.graphics.setColor(153/255, 0/255, 0, 1)
    love.graphics.printf("Timber50", 0, 50, VIRTUAL_WIDTH, 'center')
end
