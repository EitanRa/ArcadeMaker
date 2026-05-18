/// movements

//keyboard input
var movespeed = 0

if (keyDown(Keys.right))
{
    movespeed = 5
}

if (keyDown(Keys.left))
{
    movespeed = -5
}

if keyDown(Keys.space)
{
    playback.pause()
}

if keyDown(Keys.x)
{
    imageAngle += 1
}

if keyDown(Keys.z)
{
    imageAngle -= 1
}


// move

if placeFree(x + movespeed, y) == false
{
   while placeFree(x+sign(movespeed),y)
   {
       x += sign(movespeed)
   }
}
else
{
    x += movespeed
}


//gravity
fallspeed += gra

if placeFree(x,y+fallspeed) == false
{
    while placeFree(x, y + sign(fallspeed))
    {
        y += sign(fallspeed)
    }
    fallspeed = 0
}

y += fallspeed

//jump
if keyDown(Keys.up)
{
    if placeFree(x, y + 1) == false
    {
        fallspeed -= jumpspeed
    }
}

// game logic
if placeMeeting(x, y, ObjKey.i)
{
    Global.takeKey = true
    ObjKey.i.destroy()
}
else { if placeMeeting(x, y, ObjPortal.i) & Global.takeKey
{
    goToNextRoom()
}
}

if placeMeeting(x, y, <ObjSpikes>)
{
    Global.takeKey = false
    restartRoom()
}