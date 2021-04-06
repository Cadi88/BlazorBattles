using BlazorBattles.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        public IList<Unit> Units { get; } = new List<Unit>
        {
            new Unit { Id=1, Title="Knight", HitPoints=100, Attack=10, Defense=10, BananaCost=100 },
            new Unit { Id=2, Title="Archer", HitPoints=90, Attack=15, Defense=5, BananaCost=100 },
            new Unit { Id=3, Title="Mage", HitPoints=60, Attack=20, Defense=2 , BananaCost=150 }
        };

        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

        public void AddUnit(int unitId)
        {
            Unit unit = Units.First(unit => unit.Id == unitId);
            MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints });
        }
    }
}
