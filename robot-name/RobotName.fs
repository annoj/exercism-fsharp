module RobotName

open System

type Robot = {Name: string}

let randomName() = 
    let rand = Random(Guid.NewGuid().GetHashCode())
    let c() = char (rand.Next(0x41, 0x5b))
    let d = rand.Next(999)
    sprintf "%c%c%03d" (c()) (c()) d

let mkRobot() = {Name = randomName()}

let name robot = robot.Name

let reset robot = {robot with Name = randomName()}