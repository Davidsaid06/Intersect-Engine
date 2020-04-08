using System;
using System.IO;

using Intersect.Enums;
using Intersect.Server.Entities;
using Intersect.Server.Localization;
using Intersect.Utilities;
using Intersect.Logging;
using JetBrains.Annotations;

using NCalc;

using Newtonsoft.Json;

namespace Intersect.Server.General
{

    public class Formulas
    {

        private const string FORMULAS_FILE = "resources/formulas.json";

        private static Formulas mFormulas;

        public Formula ExpFormula = new Formula("BaseExp * Power(Gain, Level)");

        public string MagicDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";
        public string PhysicalDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_Defense))";
        public string FaithDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";
        public string FireDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";
        public string IceDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";
        public string ThunderDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";
        public string EarthDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";
        public string WindDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";
        public string WaterDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";
        public string NatureDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";
        public string LightDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";
        public string DarkDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_MagicResist))";

        public string TrueDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025)";

        public static void LoadFormulas()
        {
            try
            {
                mFormulas = new Formulas();
                if (File.Exists(FORMULAS_FILE))
                {
                    mFormulas = JsonConvert.DeserializeObject<Formulas>(File.ReadAllText(FORMULAS_FILE));
                }

                File.WriteAllText(FORMULAS_FILE, JsonConvert.SerializeObject(mFormulas, Formatting.Indented));

                Expression.CacheEnabled = false;
            }
            catch (Exception ex)
            {
                throw new Exception(Strings.Formulas.missing, ex);
            }
        }

        public static int CalculateDamage(
            int baseDamage,
            DamageType damageType,
            Stats scalingStat,
            int scaling,
            double critMultiplier,
            Entity attacker,
            Entity victim
        )
        {
            if (mFormulas == null)
            {
                throw new ArgumentNullException(nameof(mFormulas));
            }

            if (attacker == null)
            {
                throw new ArgumentNullException(nameof(attacker));
            }

            if (attacker.Stat == null)
            {
                throw new ArgumentNullException(
                    nameof(attacker.Stat), $@"{nameof(attacker)}.{nameof(attacker.Stat)} is null"
                );
            }

            if (victim == null)
            {
                throw new ArgumentNullException(nameof(victim));
            }

            if (victim.Stat == null)
            {
                throw new ArgumentNullException(
                    nameof(victim.Stat), $@"{nameof(victim)}.{nameof(victim.Stat)} is null"
                );
            }

            string expressionString;
            switch (damageType)
            {
                case DamageType.Physical:
                    expressionString = mFormulas.PhysicalDamage;

                    break;
                case DamageType.Magic:
                    expressionString = mFormulas.MagicDamage;

                    break;
                case DamageType.True:
                    expressionString = mFormulas.TrueDamage;

                    break;
                case DamageType.Faith:
                    expressionString = mFormulas.FaithDamage;

                    break;
                case DamageType.Fire:
                    expressionString = mFormulas.FireDamage;

                    break;
                case DamageType.Ice:
                    expressionString = mFormulas.IceDamage;

                    break;
                case DamageType.Thunder:
                    expressionString = mFormulas.ThunderDamage;

                    break;
                case DamageType.Earth:
                    expressionString = mFormulas.EarthDamage;

                    break;
                case DamageType.Wind:
                    expressionString = mFormulas.WindDamage;

                    break;
                case DamageType.Water:
                    expressionString = mFormulas.WaterDamage;

                    break;
                case DamageType.Nature:
                    expressionString = mFormulas.NatureDamage;

                    break;
                case DamageType.Light:
                    expressionString = mFormulas.LightDamage;

                    break;
                case DamageType.Dark:
                    expressionString = mFormulas.DarkDamage;

                    break;

                default:
                    expressionString = mFormulas.TrueDamage;

                    break;
            }

            var expression = new Expression(expressionString);
            var negate = false;
            if (baseDamage < 0)
            {
                baseDamage = Math.Abs(baseDamage);
                negate = true;
            }

            if (expression.Parameters == null)
            {
                throw new ArgumentNullException(nameof(expression.Parameters));
            }

            try
            {
                expression.Parameters["BaseDamage"] = baseDamage;
                expression.Parameters["ScalingStat"] = attacker.Stat[(int) scalingStat].Value();
                expression.Parameters["ScaleFactor"] = scaling / 100f;
                expression.Parameters["CritMultiplier"] = critMultiplier;
                expression.Parameters["A_Attack"] = attacker.Stat[(int) Stats.Attack].Value();
                expression.Parameters["A_Defense"] = attacker.Stat[(int) Stats.Defense].Value();
                expression.Parameters["A_Speed"] = attacker.Stat[(int) Stats.Speed].Value();
                expression.Parameters["A_AbilityPwr"] = attacker.Stat[(int) Stats.AbilityPower].Value();
                expression.Parameters["A_MagicResist"] = attacker.Stat[(int) Stats.MagicResist].Value();
                expression.Parameters["A_Faith"] = attacker.Stat[(int)Stats.Faith].Value();
                expression.Parameters["A_Fire"] = attacker.Stat[(int)Stats.Fire].Value();
                expression.Parameters["A_Ice"] = attacker.Stat[(int)Stats.Ice].Value();
                expression.Parameters["A_Thunder"] = attacker.Stat[(int)Stats.Thunder].Value();
                expression.Parameters["A_Earth"] = attacker.Stat[(int)Stats.Earth].Value();
                expression.Parameters["A_Wind"] = attacker.Stat[(int)Stats.Wind].Value();
                expression.Parameters["A_Water"] = attacker.Stat[(int)Stats.Water].Value();
                expression.Parameters["A_Nature"] = attacker.Stat[(int)Stats.Nature].Value();
                expression.Parameters["A_Light"] = attacker.Stat[(int)Stats.Light].Value();
                expression.Parameters["A_Dark"] = attacker.Stat[(int)Stats.Dark].Value();
                expression.Parameters["V_Attack"] = victim.Stat[(int) Stats.Attack].Value();
                expression.Parameters["V_Defense"] = victim.Stat[(int) Stats.Defense].Value();
                expression.Parameters["V_Speed"] = victim.Stat[(int) Stats.Speed].Value();
                expression.Parameters["V_AbilityPwr"] = victim.Stat[(int) Stats.AbilityPower].Value();
                expression.Parameters["V_MagicResist"] = victim.Stat[(int) Stats.MagicResist].Value();
                expression.Parameters["V_Faith"] = victim.Stat[(int)Stats.Faith].Value();
                expression.Parameters["V_Fire"] = victim.Stat[(int)Stats.Fire].Value();
                expression.Parameters["V_Ice"] = victim.Stat[(int)Stats.Ice].Value();
                expression.Parameters["V_Thunder"] = victim.Stat[(int)Stats.Thunder].Value();
                expression.Parameters["V_Earth"] = victim.Stat[(int)Stats.Earth].Value();
                expression.Parameters["V_Wind"] = victim.Stat[(int)Stats.Wind].Value();
                expression.Parameters["V_Water"] = victim.Stat[(int)Stats.Water].Value();
                expression.Parameters["V_Nature"] = victim.Stat[(int)Stats.Nature].Value();
                expression.Parameters["V_Light"] = victim.Stat[(int)Stats.Light].Value();
                expression.Parameters["V_Dark"] = victim.Stat[(int)Stats.Dark].Value();
                expression.EvaluateFunction += delegate(string name, FunctionArgs args)
                {
                    if (args == null)
                    {
                        throw new ArgumentNullException(nameof(args));
                    }

                    if (name == "Random")
                    {
                        args.Result = Random(args);
                    }
                };

                var result = Convert.ToDouble(expression.Evaluate());
                if (negate)
                {
                    result = -result;
                }
                var res= (int)Math.Round(result);
                Log.Debug($"Daño efectuado: {res}.");
                switch (damageType)
                {
                    case DamageType.Fire:
                        return ElementalDamage(res, attacker.Stat[(int)Stats.Fire].ValueElement(),
                            victim.Stat[(int)Stats.Ice].ValueElement(), victim.Stat[(int)Stats.Nature].ValueElement(),
                            victim.Stat[(int)Stats.Earth].ValueElement(), victim.Stat[(int)Stats.Water].ValueElement());
                    case DamageType.Ice:
                        return ElementalDamage(res, attacker.Stat[(int)Stats.Ice].ValueElement(),
                            victim.Stat[(int)Stats.Earth].ValueElement(), victim.Stat[(int)Stats.Water].ValueElement(),
                            victim.Stat[(int)Stats.Fire].ValueElement(), victim.Stat[(int)Stats.Wind].ValueElement());
                    case DamageType.Thunder:
                        return ElementalDamage(res, attacker.Stat[(int)Stats.Thunder].ValueElement(),
                            victim.Stat[(int)Stats.Wind].ValueElement(), victim.Stat[(int)Stats.Water].ValueElement(),
                            victim.Stat[(int)Stats.Earth].ValueElement(), victim.Stat[(int)Stats.Nature].ValueElement());
                    case DamageType.Earth:
                        return ElementalDamage(res, attacker.Stat[(int)Stats.Earth].ValueElement(),
                            victim.Stat[(int)Stats.Fire].ValueElement(), victim.Stat[(int)Stats.Thunder].ValueElement(),
                            victim.Stat[(int)Stats.Ice].ValueElement(), victim.Stat[(int)Stats.Water].ValueElement());
                    case DamageType.Wind:
                        return ElementalDamage(res, attacker.Stat[(int)Stats.Wind].ValueElement(),
                            victim.Stat[(int)Stats.Ice].ValueElement(), victim.Stat[(int)Stats.Ice].ValueElement(),
                            victim.Stat[(int)Stats.Thunder].ValueElement(), victim.Stat[(int)Stats.Thunder].ValueElement());
                    case DamageType.Water:
                        return ElementalDamage(res, attacker.Stat[(int)Stats.Water].ValueElement(),
                            victim.Stat[(int)Stats.Fire].ValueElement(), victim.Stat[(int)Stats.Earth].ValueElement(),
                            victim.Stat[(int)Stats.Ice].ValueElement(), victim.Stat[(int)Stats.Thunder].ValueElement());
                    case DamageType.Nature:
                        return ElementalDamage(res, attacker.Stat[(int)Stats.Nature].ValueElement(),
                            victim.Stat[(int)Stats.Thunder].ValueElement(), victim.Stat[(int)Stats.Thunder].ValueElement(),
                            victim.Stat[(int)Stats.Fire].ValueElement(), victim.Stat[(int)Stats.Fire].ValueElement());
                    case DamageType.Light:
                        return res;
                    case DamageType.Dark:
                        return res;
                    default:
                        return res;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to evaluate damage formula", ex);
            }
        }

        private static int Random([NotNull] FunctionArgs args)
        {
            if (args.Parameters == null)
            {
                throw new ArgumentNullException(nameof(args.Parameters));
            }

            var parameters = args.EvaluateParameters() ??
                             throw new NullReferenceException($"{nameof(args.EvaluateParameters)}() returned null.");

            if (parameters.Length < 2)
            {
                throw new ArgumentException($"{nameof(Random)}() requires 2 numerical parameters.");
            }

            var min = (int) Math.Round(
                (double) (parameters[0] ?? throw new NullReferenceException("First parameter is null."))
            );

            var max = (int) Math.Round(
                (double) (parameters[1] ?? throw new NullReferenceException("First parameter is null."))
            );

            return min >= max ? min : Globals.Rand.Next(min, max + 1);
        }

        private static int ElementalDamage(int res,int a_element,int v_elementStrong1,int v_elementStrong2,int v_elementWeak1, int v_elementWeak2)
        {



            Log.Debug($" Valor Elemento Ataque: {a_element}.");
            Log.Debug($" Valor Elemento Victima 1: {v_elementStrong1}.");
            Log.Debug($" Valor Elemento Victima 2: {v_elementStrong2}.");
            Log.Debug($" Valor Elemento Victima 3: {v_elementWeak1}.");
            Log.Debug($" Valor Elemento Victima 4: {v_elementWeak2}.");

            if (a_element > 0)
            {
                //Start of the fire element
                double basePercentage = ((double)a_element / 10);
                Log.Debug($"Base Percentage: {basePercentage}.");

                int extraDamage = (int)(res * basePercentage);
                Log.Debug($"Extra Damage: {extraDamage}.");

                double plusPercentage = 0;
                int plusCount = 0;
                double minusPercentage = 0;
                int minusCount = 0;
                //Strong against
                if (v_elementStrong1 > 0)
                {
                    plusPercentage = plusPercentage + (((double)a_element / (double)v_elementStrong1)) / 2;
                    plusCount++;
                    Log.Debug($"Plus Percentage 1: {plusPercentage}.");

                }
                if (v_elementStrong2 > 0)
                {
                    plusPercentage = plusPercentage + (((double)a_element / (double)v_elementStrong2)) / 2;
                    plusCount++;
                    Log.Debug($"Plus Percentage 2: {plusPercentage}.");

                }
                if (plusCount > 0)
                {
                    plusPercentage = plusPercentage / plusCount;
                }

                //Weak Against
                if (v_elementWeak1 > 0)
                {
                    minusPercentage = minusPercentage + (((double)v_elementWeak1 /(double)a_element)) / 2;
                    minusCount++;
                    Log.Debug($"Minus Percentage 1: {minusPercentage}.");
                }
                if (v_elementWeak2 > 0)
                {
                    minusPercentage = minusPercentage + (((double)v_elementWeak2 / (double)a_element)) / 2;
                    minusCount++;
                    Log.Debug($"Minus Percentage 2: {minusPercentage}.");
                }
                if (minusCount > 0)
                {
                    minusPercentage = minusPercentage / minusCount;
                }

                double totalPercentage = plusPercentage - minusPercentage;
                Log.Debug($"Total Percentage: {totalPercentage}.");

                res = (int)Math.Round(res + (extraDamage * totalPercentage));

                if (res < 0)
                {
                    res = 0;
                }
            }
            Log.Debug($"Daño efectuado Total: {res}.");
            return res;
        }


    }

}
