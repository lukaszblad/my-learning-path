--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

function GenerateQuads(atlas, tilewidth, tileheight)
    local sheetWidth = atlas:getWidth() / tilewidth
    local sheetHeight = atlas:getHeight() / tileheight

    local sheetCounter = 1
    local spritesheet = {}

    for y = 0, sheetHeight - 1 do
        for x = 0, sheetWidth - 1 do
            spritesheet[sheetCounter] =
                love.graphics.newQuad(x * tilewidth, y * tileheight, tilewidth,
                tileheight, atlas:getDimensions())
            sheetCounter = sheetCounter + 1
        end
    end

    return spritesheet
end

function printState(text, y)
    love.graphics.setFont(gFonts['pixel-small'])
    love.graphics.setColor(1, 1, 1, 1)
    love.graphics.print(text, 0, y)
end

function loadScores()
    love.filesystem.setIdentity('timber50')
    -- love.filesystem.remove("scores.lst")
    if not love.filesystem.getInfo('scores.lst') then
        local scores = ''
        for i = 7, 1, -1 do
            scores = scores .. 'AAA' .. tostring(i * 10) .. '\n'
        end
        love.filesystem.write('scores.lst', scores)
    end

    local scores = {}
    local index = 1
    for line in love.filesystem.lines('scores.lst') do
        scores[index] = {
            name = string.sub(line, 1, 3),
            points = tonumber(string.sub(line, 4)),
            y = index * 30
        }
        index = index + 1
    end

    return scores
end
