--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

-- load atlases
gTextures = {
    ['gui'] = love.graphics.newImage('graphics/gui.png'),
    ['backgrounds'] = love.graphics.newImage('graphics/backgrounds.png'),
    ['sprites'] = love.graphics.newImage('graphics/sprites.png'),
    ['branches'] = love.graphics.newImage('graphics/branches.png'),
    ['characters'] = love.graphics.newImage('graphics/characters.png')
}

-- divide atlases in tiles 16x16
gFrames = {
    ['gui'] = GenerateQuads(gTextures['gui'], 128, 64),
    ['backgrounds'] = GenerateQuads(gTextures['backgrounds'], 512, 288),
    ['wood'] = GenerateQuads(gTextures['sprites'], WOOD_BLOCK_SIZE, WOOD_BLOCK_SIZE),
    ['branches'] = GenerateQuads(gTextures['branches'], WOOD_BLOCK_SIZE, 16),
    ['characters'] = GenerateQuads(gTextures['characters'], CHARACTER_WIDTH, CHARACTER_HEIGHT)
}

gFonts = {
    ['title-small'] = love.graphics.newFont('fonts/karma/Karma Suture.otf', 8),
    ['title-medium'] = love.graphics.newFont('fonts/karma/Karma Suture.otf', 16),
    ['title-large'] = love.graphics.newFont('fonts/karma/Karma Suture.otf', 32),
    ['pixel-small'] = love.graphics.newFont('fonts/fipps/Fipps-Regular.otf', 8),
    ['pixel-medium'] = love.graphics.newFont('fonts/fipps/Fipps-Regular.otf', 16),
    ['pixel-large'] = love.graphics.newFont('fonts/fipps/Fipps-Regular.otf', 32),
    ['small'] = love.graphics.newFont('fonts/jaro/Jaro-Regular.ttf', 8),
    ['medium'] = love.graphics.newFont('fonts/jaro/Jaro-Regular.ttf', 16),
    ['large'] = love.graphics.newFont('fonts/jaro/Jaro-Regular.ttf', 32),
}

gSounds = {
    ['select'] = love.audio.newSource('sounds/select.wav', 'static'),
    ['hit'] = love.audio.newSource('sounds/hit.wav', 'static'),
    ['menu-music'] = love.audio.newSource('sounds/music.wav', 'static'),
    ['chop'] = love.audio.newSource('sounds/chop.wav', 'static'),
}
