using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace doctornoodlearms.TemplateMod;

public class BasicRelic : RelicModel{

    // The rarity of the relic
    public override RelicRarity Rarity => RelicRarity.None;

    // There are a ton of virtual methods for just about everything
    // Ex: Card Played | Before Damage Recieved | Modify Damage Amount | After Damage Recieved | After Damage Recieved Late | After Damage Given
}