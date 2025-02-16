namespace ReforgesReworked.Content.Prefix {
    public class Humongous : Gigantic {
        public override float Power => base.Power + 1f;
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
    }

    public class Behemoth : Gigantic {
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 2;
        public override float Power => base.Power + 2f; 
    }

    public class Serrated : Razorsharp {
        public override float Power => base.Power + 1;
        public override double AbsolutePower => base.AbsolutePower * 1.5;
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
    }

    public class Energised : Dynamic {
        public override float Power => base.Power + 1f;
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
    }

    public class Vigorous : Dynamic {
        public override float Power => base.Power + 2f;
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 2;
    }

    public class Refined : Honed {
        public override float Power => base.Power * 2;
        public override double AbsolutePower => base.AbsolutePower * 1.5;
        public override int MinimumPrefixTier => base.MinimumPrefixTier + 1;
    }
}