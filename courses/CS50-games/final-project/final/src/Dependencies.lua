--[[
    GD50 Final Project
    Timber50
    Author: Łukasz Błąd
    Github: https://github.com/lukaszblad
]]

------------
-- libraries
------------
Class = require 'libraries/class'
push = require 'libraries/push'
Timer = require 'libraries/knife.timer'

-------------------
-- internal modules
-------------------
-- utils
require 'src/constants'
require 'src/Util'
require 'src/static'
require 'src/controls'
require 'src/StateMachine'
require 'src/Animation'
require 'src/states/BaseState'
require 'src/states/StateStack'
require 'src/Background'
require 'src/WoodBlock'
-- defs
require 'src/defs/graphicsDefs'
-- gui
require 'src/gui/MenuButton'
-- games states
require 'src/states/game/PlayState'
require 'src/states/game/ScoresState'
require 'src/states/game/EnterHighScore'
require 'src/states/game/TitleState'
require 'src/states/game/MenuState'
require 'src/states/game/GameOverState'
-- entity states
require 'src/states/player/PlayerIdleState'
require 'src/states/player/PlayerChoppingState'
-- level
require 'src/Level'
-- entities
require 'src/Player'
