﻿namespace CarLibrary;

public abstract class Car
{
    public string? PetName {get; set;}
    public int? CurrentSpeed {get; set;}
    public int? MaxSpeed {get; set;}

    protected EngineStateEnum State = EngineStateEnum.EngineAlive;
    public EngineStateEnum EngineState => State;
    public abstract void TurboBoost();

    protected Car(){}
    protected Car(string name, int maxSpeed, int currentSpeed)
    {
        PetName = name;
        MaxSpeed = maxSpeed;
        CurrentSpeed = currentSpeed;
    }
}
