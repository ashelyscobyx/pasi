// Create a list of objects to insert
var objects = new List<object>();
objects.Add(new Product { Id = 1, Name = "Laptop", Price = 999.99 });
objects.Add(new Customer { Id = 2, Name = "Alice", Email = "alice@example.com" });

// Create a repository instance
var repo = new Repository();

// Insert the objects into the repository
repo.Insert(objects);

// Save the changes to the data source
repo.SaveChanges();
