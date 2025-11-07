using System;
using System.Collections.Generic;

public class TakingTurnsQueue
{
    private readonly Queue<Person> _people = new Queue<Person>();

    public int Length => _people.Count;

    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    public Person GetNextPerson()
    {
        if (_people.Count == 0)
            throw new InvalidOperationException("No one in the queue.");

        var person = _people.Dequeue();

        if (person.Turns <= 0)
        {
            // Infinite turns
            _people.Enqueue(person);
        }
        else if (person.Turns > 1)
        {
            person.Turns -= 1;
            _people.Enqueue(person);
        }
        // If Turns == 1, do not re-add

        return person;
    }
}
