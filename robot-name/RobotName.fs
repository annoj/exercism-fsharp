module RobotName

open System

type Robot = {Name: string}

let randomName() = 
    let rand = Random(Guid.NewGuid().GetHashCode())
    let chars = ['A' .. 'Z']
    let l1 = chars.[rand.Next(chars.Length)].ToString()
    let l2 = chars.[rand.Next(chars.Length)].ToString()
    let d = rand.Next(999)
    sprintf "%s%s%03d" l1 l2 d

let mkRobot() = {Name = randomName()}

let name robot = robot.Name

let reset robot = {robot with Name = randomName()}