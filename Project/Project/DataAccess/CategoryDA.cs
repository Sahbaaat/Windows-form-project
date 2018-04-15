using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain;

namespace Project.DataAccess
{
    class CategoryDA
    {
        static public List<Category> categories;
        private static CategoryDA instance;
        public static CategoryDA Instance             ///singleton
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDA();
                }
                return instance;
            }
        }
        public CategoryDA()
        {
            categories = new List<Category>();

            Category sport = new Category("ورزشی");
            Category art = new Category("هنری");
            Category funny = new Category("تفریحی");
            CategoryDA.AddCategory(sport);
            CategoryDA.AddCategory(art);
            CategoryDA.AddCategory(funny);
            Activity football = new Activity("footbal", "footbal", 1, 2, 3, 4);
            Activity basketball = new Activity("basketball", "basketball", 5, 4, 3, 2);
            sport.AddActivity(football);
            sport.AddActivity(basketball);
            Activity painting = new Activity("painting", "painting", 2, 2, 2, 2);
            Activity music = new Activity("music", "music", 1, 1, 1, 1);
            art.AddActivity(painting);
            art.AddActivity(music);
            SuggestedActivity dance = new SuggestedActivity("gaming", "gaming", 1, 2, 3, 5);
            funny.AddSuggestedActivity(dance);
            SuggestedActivity biking = new SuggestedActivity("biking", "biking", 4, 3, 2, 5);
            SuggestedActivity baseball = new SuggestedActivity("baseball", "baseball", 2, 3, 4, 1);
            sport.AddSuggestedActivity(biking);
            sport.AddSuggestedActivity(baseball);
        }
        static public List<Category> CategoriesList()
        {
            return categories;
        }
        static public void AddCategory(Category c)
        {
            categories.Add(c);
        }
    }
}
