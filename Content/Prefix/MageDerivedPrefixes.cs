using System;

namespace ReforgesReworked.Content.Prefix {
    public class Anchored : Focused {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
        public override float Power => base.Power + 1f; 
    }

    public class Pivoted : Focused {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 2;
        public override float Power => base.Power + 2f;   
    }

    public class Spontaineous : Explosive {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
        public override float Power => base.Power + 1f;   
    }

    public class Exothermic : Volatile {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
        public override float Power => base.Power + 1f;
        public override int AbsolutePower => base.AbsolutePower + 1;
    }

    public class Combustable : Volatile {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 2;
        public override float Power => base.Power + 2f;
        public override int AbsolutePower => base.AbsolutePower + 2;
    }

    public class Experienced : Proficient {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
        public override float Power => base.Power + 1f;
        public override int AbsolutePower => base.AbsolutePower + 1;
    }

    public class Enchanted : Charged {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
        public override float Power => base.Power + 1f;
        public override int AbsolutePower => base.AbsolutePower + 1;
    }
}