--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

GUI_DEFS = {
    menuButtons = {
        playButton = {
            name = 'play',
            action = 'play',
            texture = 1,
            width = 128,
            height = 64,
            y = 100,
        },
        scoresButton = {
            name = 'scores',
            action = 'scores',
            texture = 4,
            width = 128,
            height = 64,
            y = 180,
        },
    },
    gameOverButtons = {
        exitButton = {
            name = 'exit',
            action = 'menu',
            texture = 2,
            width = 128,
            height = 64,
            y = - 64,
        },
        playAgainButton = {
            name = 'play-again',
            action = 'play',
            texture = 3,
            width = 128,
            height = 64,
            y = - 150,
        }
    }
}

BACKGROUNDS_DEFS = {
    springBackground = {
        texture = 1
    }
}

WOOD_DEFS = {
    oakWood = {
        texture = 1
    }
}

PLAYER_DEFS = {
    idleState = {
        ['left'] = 1,
        ['right'] = 3,
    },
    choppingState = {
        ['left'] = 2,
        ['right'] = 4,
    }
}
