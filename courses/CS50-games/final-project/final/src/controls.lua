--[[
    GD50 Final Project
    50Force
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

function love.keypressed(key)
    love.keyboard.keysPressed[key] = true
    table.insert(love.keyboard.keysTable, key)
    if key == 'escape' then
        love.event.quit()
    end
end

function love.keyboard.wasPressed(key)
    if love.keyboard.keysPressed[key] then
        return true
    else
        return false
    end
end

function love.mousepressed(x, y, key)
    love.mouse.keysPressed[key] = true
end

function love.mouse.wasPressed(key)
    return love.mouse.keysPressed[key]
end
