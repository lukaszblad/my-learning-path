--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

-- physical screen dimensions
WINDOW_WIDTH = 1280
WINDOW_HEIGHT = 720
-- virtual resolution dimensions
VIRTUAL_WIDTH = 512
VIRTUAL_HEIGHT = 288

WOOD_BLOCK_SIZE = 64
WOOD_BLOCK_X = VIRTUAL_WIDTH / 2 - WOOD_BLOCK_SIZE / 2

CHARACTER_WIDTH = 80
CHARACTER_HEIGHT = 64
LEFT_SIDE_X = WOOD_BLOCK_X - (CHARACTER_WIDTH)
RIGHT_SIDE_X = WOOD_BLOCK_X + (CHARACTER_WIDTH-16)

GROUND_HEIGHT = VIRTUAL_HEIGHT - 50
