namespace CretaceousApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    // public AnimalList<Animal> GetAnimals(AnimalParameters animalParameters)
    // {
    //   return AnimalList<Animal>.ToPagedList(FindAll().OrderBy(animal => animal.Name), animalParameters.PageNumber, animalParameters.PageSize);
    // }
  }
}