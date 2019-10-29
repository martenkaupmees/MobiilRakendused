using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ListExercise.Core.Oige;

namespace ListExercise
{
    [Activity(Label = "StarWarsListActivity")]
    public class StarWarsListActivity : ListActivity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var queryString = "https://swapi.co/api/people/?search=darth";

            var data = await Core.Oige.DataService.GetDataFromPeople(queryString);
            var people = data as People;
            ListAdapter = new StarWarsPeopleAdapter(this, people.Results);
        }
    }
}