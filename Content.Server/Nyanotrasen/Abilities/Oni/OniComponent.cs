using Content.Shared.Damage;

namespace Content.Server.Abilities.Oni
{
    [RegisterComponent]
    public sealed class OniComponent : Component
    {
        [DataField("modifiers", required: true)]
        public DamageModifierSet MeleeModifiers = default!;

        [DataField("stamDamageBonus")]
        public float StamDamageMultiplier = 1.35f;
    }
}
