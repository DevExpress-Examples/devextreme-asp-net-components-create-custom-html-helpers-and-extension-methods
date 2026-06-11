using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlHelpersExtensions.Models
{
    static class SampleData
    {
        public static readonly List<State> States = new List<State> {
            new State {
                ID = 1,
                Name = "Alabama"
            },
            new State {
                ID = 2,
                Name = "Alaska"
            },
            new State {
                ID = 3,
                Name = "Arizona"
            },
            new State {
                ID = 4,
                Name = "Arkansas"
            },
            new State {
                ID = 5,
                Name = "California"
            }
        };

        public static List<CityByState> CitiesByState = new List<CityByState> {
            new CityByState {
                ID = 1,
                Name = "Tuscaloosa",
                StateID = 1
            },
            new CityByState {
                ID = 2,
                Name = "Hoover",
                StateID = 1
            },
            new CityByState {
                ID = 3,
                Name = "Dothan",
                StateID = 1
            },
            new CityByState {
                ID = 4,
                Name = "Decatur",
                StateID = 1
            },
            new CityByState {
                ID = 5,
                Name = "Anchorage",
                StateID = 2
            },
            new CityByState {
                ID = 6,
                Name = "Fairbanks",
                StateID = 2
            },
            new CityByState {
                ID = 7,
                Name = "Juneau",
                StateID = 2
            },
            new CityByState {
                ID = 8,
                Name = "Avondale",
                StateID = 3
            },
            new CityByState {
                ID = 9,
                Name = "Buckeye",
                StateID = 3
            },
            new CityByState {
                ID = 10,
                Name = "Carefree",
                StateID = 3
            },
            new CityByState {
                ID = 11,
                Name = "Springdale",
                StateID = 4
            },
            new CityByState {
                ID = 12,
                Name = "Rogers",
                StateID = 4
            },
            new CityByState {
                ID = 13,
                Name = "Sherwood",
                StateID = 4
            },
            new CityByState {
                ID = 14,
                Name = "Jacksonville",
                StateID = 4
            },
            new CityByState {
                ID = 15,
                Name = "Cabot",
                StateID = 4
            },
            new CityByState {
                ID = 16,
                Name = "Adelanto",
                StateID = 5
            },
            new CityByState {
                ID = 17,
                Name = "Glendale",
                StateID = 5
            },
            new CityByState {
                ID = 18,
                Name = "Moorpark",
                StateID = 5
            },
            new CityByState {
                ID = 19,
                Name = "Needles",
                StateID = 5
            },
            new CityByState {
                ID = 20,
                Name = "Ontario",
                StateID = 5
            }
        };
        public static List<SampleOrder> Orders = new List<SampleOrder>() {
            new SampleOrder {
                OrderID = 10248,
                OrderDate = new DateTime(1996, 7, 4),
                State = 1,
                City = 2,
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10249,
                OrderDate = new DateTime(1996, 7, 5),
                State = 2,
                City = 5,
                CustomerName = "Karin Josephs"
            },
            new SampleOrder {
                OrderID = 10250,
                OrderDate = new DateTime(1996, 7, 8),
                State = 3,
                City = 8,
                CustomerName = "Mario Pontes"
            },
            new SampleOrder {
                OrderID = 10251,
                OrderDate = new DateTime(1996, 7, 8),
               State = 3,
                City = 9,
                CustomerName = "Mary Saveley"
            },
            new SampleOrder {
                OrderID = 10252,
                OrderDate = new DateTime(1996, 7, 9),
                State = 3,
                City = 8,
                CustomerName = "Pascale Cartrain"
            },
            new SampleOrder {
                OrderID = 10253,
                OrderDate = new DateTime(1996, 7, 10),
                State = 3,
                City = 10,
                CustomerName = "Mario Pontes"
            },
            new SampleOrder {
                OrderID = 10254,
                OrderDate = new DateTime(1996, 7, 11),
                State = 3,
                City = 10,
                CustomerName = "Yang Wang"
            },
            new SampleOrder {
                OrderID = 10255,
                OrderDate = new DateTime(1996, 7, 12),
                State = 1,
                City = 2,
                CustomerName = "Michael Holz"
            },
            new SampleOrder {
                OrderID = 10256,
                OrderDate = new DateTime(1996, 7, 15),
                State = 2,
               City = 4,
                CustomerName = "Paula Parente"
            }
        };
    }
}
