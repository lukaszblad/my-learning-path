--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

-- RUN shortcut Ctrl + Shift + Alt + L

require 'src/Dependencies'

function love.load()
    love.window.setTitle('Timber50')
    
    -- removing blur filter
    love.graphics.setDefaultFilter('nearest', 'nearest')

    -- virtual resolution setup
    push:setupScreen(VIRTUAL_WIDTH, VIRTUAL_HEIGHT, WINDOW_WIDTH, WINDOW_HEIGHT, {
        vsync = true,
        fullscreen = false, -- to change
        resizable = true
    })

    gStateMachine = StateMachine {
        ['title'] = function() return TitleState() end,
        ['menu'] = function() return MenuState() end,
        ['play'] = function() return PlayState() end,
        ['game-over'] = function() return GameOverState() end,
        ['scores'] = function() return ScoresState() end,
        ['high-score'] = function() return EnterHighScore() end,
    }
    gStateMachine:change('title', {
        title = "Okayū Games",
        nextState = 'title',
        nextTitle = 'CS50 Games Final Project',
    })

    love.keyboard.keysPressed = {}
    love.keyboard.keysTable = {}
    love.mouse.keysPressed = {}

    math.randomseed(os.time())

    -- FPS cap
    min_dt = 1/60
    next_time = love.timer.getTime()
end

function love.update(dt)
    gStateMachine:update(dt)
    love.keyboard.keysPressed = {}
    love.keyboard.keysTable = {}
    love.mouse.keysPressed = {}
    Timer.update(dt)
end

function love.draw()
    push:start()
        gStateMachine:render()
    push:finish()

    -- FPS cap
    local cur_time = love.timer.getTime()
    if next_time <= cur_time then
       next_time = cur_time
       return
    end
    love.timer.sleep(next_time - cur_time)
end