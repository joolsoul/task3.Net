namespace task3.impl;

public class Earth : Planet
{
    public Earth(Star sun) 
        : base("Earth", 59.7, 6371d, sun, 1d, 29.765, 465) {}
    
}