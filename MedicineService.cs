using QuintoProyecto.Models;

namespace QuintoProyecto.Services;

public class MedicineService() {


  private readonly List<Medicine> _medicines = [
    new Medicine{
      Id = 1,
      Name = "Paracetamol",
      Category = "Analgésico",
      Laboratory = "Genfar"
    },

    new Medicine{
      Id = 2,
      Name = "Amoxicilina",
      Category = "Antibiótico",
      Laboratory = "Pfizer"
    }
  ];

  public List<Medicine> FindAll() {
    return _medicines;
  }

  public bool Delete(int id) {
    var medicine = _medicines.FirstOrDefault((m) => m.Id == id);

    if (medicine is null) {
      return false;
    }

  
    _medicines.Remove(medicine);

    return true;
  }

  public bool Create(Medicine medicine) {
    _medicines.Add(medicine);
    return true;
  }
}

