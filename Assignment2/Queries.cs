namespace Assignment2;
public class Queries
{
    public static IEnumerable<string> LINQgetRowlingWizards(){
        var wizards = WizardCollection.Create();

        var rowlings = (from w in wizards
                        where w.Creator.Contains("Rowling") 
                        select w.Name).Distinct();
        return rowlings;
        
//              join c in repo.Cities on h.CityId equals c.Id
//             //  where c.Name == "Gotham City"
//              orderby h.FirstAppearance descending, h.AlterEgo
//              select new { h.AlterEgo, h.FirstAppearance, City = c.Name };

        // var heroes0 = repo.Superheroes
//     // .Where(h => h.City == "Gotham City")
//     .OrderByDescending(h => h.FirstAppearance)
//     .ThenBy(h => h.AlterEgo)
//     .Select(h => new { h.AlterEgo, h.FirstAppearance });
        
    }

    public static IEnumerable<string> ExtensionGetRowlingWizards(){
        var wizards = WizardCollection.Create();

        var rowlings = wizards.Where(w => w.Creator.Contains("Rowling")).Select(h => h.Name).Distinct();
        return rowlings;
    }

    public static int? LINQgetYearOfFirstSithLord(){
        var wizards = WizardCollection.Create();

        var firstDarth = (from w in wizards
                        where w.Name.Contains("Darth")
                        orderby w.Year ascending
                        select w.Year).FirstOrDefault();
        return firstDarth;
    }

    public static int? ExtensionGetYearOfFirstSithLord(){
        var wizards = WizardCollection.Create();

        var firstDarth = wizards.Where(w => w.Name.Contains("Darth")).OrderBy(w => w.Year).Select(w => w.Year).FirstOrDefault();
        return firstDarth;
    }

    public static IEnumerable<(string, int?)> LINQgetHPWizardTuples(){
        var wizards = WizardCollection.Create();
        var uniqueWizards = (from w in wizards
                        where w.Medium.Contains("Harry Potter")
                        select (w.Name, w.Year)).DistinctBy(w => w.Name);

        return uniqueWizards;
    }

    public static IEnumerable<(string, int?)> ExtensionsGetHPWizardTuples(){
        var wizards = WizardCollection.Create();
        var uniqueWizards = wizards.Where(w => w.Medium.Contains("Harry Potter")).Select(w => (w.Name, w.Year)).DistinctBy(w => w.Name);

        return uniqueWizards;
    }

    public static IEnumerable<string> LINQGroupByNameInReverseThenCreator(){
        var wizards = WizardCollection.Create();
        var names = (from w in wizards
        orderby w.Creator descending, w.Name descending
        group w by w.Creator into newGroup1
        from v in newGroup1
        select v.Name).Distinct();

        return names;
    }

    public static IEnumerable<string> ExtensionGroupByNameInReverseThenCreator(){
        var wizards = WizardCollection.Create();
        var names = wizards.OrderByDescending(g => g.Creator).ThenByDescending(g => g.Name).GroupBy(g => g.Creator).Flatten().Select(w => w.Name).Distinct(); 
        return names;
    }
}
