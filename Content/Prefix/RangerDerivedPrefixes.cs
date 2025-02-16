namespace ReforgesReworked.Content.Prefix {
    public class Psycho : Lunatic {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
        public override float Power => base.Power + 1f; 
    }

    public class Eccentric : Lunatic {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 2;
        public override float Power => base.Power + 2f; 
    }

    public class Encyclopedic : Exhaustive {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
        public override float Power => base.Power + 1f; 
    }

    public class Crackshot : Marksman {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
        public override float Power => base.Power + 1f; 
    }

    public class Bersagliere : Sharpshooter {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
        public override float Power => base.Power + 1f; 
    }
}