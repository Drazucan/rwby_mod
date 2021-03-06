﻿using System;
using Terraria.ModLoader;

namespace rwby_mod.Projectiles
{
    public class EmberCelicaBlast : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Ember Celica Blast";
            projectile.width = 65;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 5;
            projectile.timeLeft = 200;
            projectile.light = 5f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()       //This will face the projectile the correct way
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
    }
}
