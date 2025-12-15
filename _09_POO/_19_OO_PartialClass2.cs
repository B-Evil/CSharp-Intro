namespace OurCompany.LearnCoding.OOP.PartialClass;

public partial class Customer{
    public string Name { get; set; }
    public override string ToString(){
        return $"[ID: {ID} - Name: {Name}]";
    }
}