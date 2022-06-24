select a.Name from Animal a
join ZooAnimal za
on a.Id = za.AnimalId
where za.ZooId = 1