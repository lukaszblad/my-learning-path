PlayerIdleLiftingState = Class{__includes = EntityIdleState}

function PlayerIdleLiftingState:enter(params)
self.entity:changeAnimation('idle-lifting-' .. self.entity.direction)

-- render offset for spaced character sprite (negated in render function of state)
self.entity.offsetY = 5
self.entity.offsetX = 0
end

function PlayerIdleLiftingState:update(dt)

    if love.keyboard.isDown('left') or love.keyboard.isDown('right') or
       love.keyboard.isDown('up') or love.keyboard.isDown('down') then
        self.entity:changeState('walk-lifting')
    end
end
