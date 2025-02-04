namespace ReforgesReworked.Content.Prefix {

    public class Sacrifistic : Vampiric {
        public override int AbsolutePower => base.AbsolutePower * 2;
    }

    public class Masochistic : Vampiric {
        public override int AbsolutePower => base.AbsolutePower * 3;
    }

    public class Psychotic : Spiritual {
        public override float Power => base.Power * 2;
        public override int AbsolutePower => base.AbsolutePower * 2;
    }

    public class Transcendent : Spiritual {
        public override float Power => base.Power * 3;
        public override int AbsolutePower => base.AbsolutePower * 3;
    }

    public class Risky : Gambling {
        public override float Power => base.Power * 2;
        public override int AbsolutePower => base.AbsolutePower * 2;
    }

    public class Bluffer : Gambling {
        public override float Power => base.Power * 3;
        public override int AbsolutePower => base.AbsolutePower * 3;
    }

    public class Vulnerable : Exposed {
        public override float Power => base.Power * 1.8f;
        public override int AbsolutePower => base.AbsolutePower * 2;
    }

    public class Unveiled : Exposed {
        public override float Power => base.Power * 2.2f;
        public override int AbsolutePower => base.AbsolutePower * 3;
    }

    public class Defenseless : Exposed {
        public override float Power => base.Power * 2.6f;
        public override int AbsolutePower => base.AbsolutePower * 5;
    }

    public class Collecter : Symbiotic {
        public override float Power => base.Power * 1.75f;
        public override int AbsolutePower => base.AbsolutePower * 2;
    }

    public class Popular : Symbiotic {
        public override float Power => base.Power * 2.5f;
        public override int AbsolutePower => base.AbsolutePower * 3;
    }

    public class Remote : Lonely {
        public override float Power => base.Power * 1.75f;
        public override int AbsolutePower => base.AbsolutePower * 2;
        public override int minimum_summon => 2;
    }

    public class Isolated : Lonely {
        public override float Power => base.Power * 2.5f;
        public override int AbsolutePower => base.AbsolutePower * 3;
        public override int minimum_summon => 3;
    }

    public class Tempered : Fierce {
        public override float Power => base.Power * 2f;
        public override int AbsolutePower => base.AbsolutePower * 2;
    }
}