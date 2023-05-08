using Dalamud.Game.ClientState.Objects.Types;
using ECommons;
using ECommons.DalamudServices;
using ECommons.Logging;
using System.Numerics;
using ImGuiNET;
using Splatoon.SplatoonScripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommons.Configuration;
using Dalamud.Interface.Colors;
using ECommons.Schedulers;
using ECommons.Hooks;
using ECommons.Hooks.ActionEffectTypes;
using ECommons.Throttlers;
using ECommons.MathHelpers;

namespace SplatoonScriptsOfficial.Duties.Endwalker.The_Omega_Protocol
{
    public class Exasquares : SplatoonScript
    {
        public override HashSet<uint> ValidTerritories => new() { 1122 };
        public override Metadata? Metadata => new(5, "Errer/yoyo预设绘制 P6宇宙天剑安全点  ");
        TickScheduler? sch;
        TickScheduler? doTask;
        bool mechanicResolved = false;

        public override void OnSetup()
        {
            var exasquaresIn = "~Lv2~{\"Name\":\"内圈4 10 1\",\"Group\":\"\",\"ZoneLockH\":[1122],\"DCond\":5,\"ElementsL\":[{\"Name\":\"\",\"refX\":96.4131,\"refY\":103.60656,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":96.4131,\"refY\":96.647,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":103.553,\"refY\":103.60656,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":103.493,\"refY\":96.367,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0}],\"UseTriggers\":true,\"Triggers\":[{\"Type\":2,\"Duration\":4.0,\"Match\":\"(12256>31651)\",\"MatchDelay\":8.0,\"FireOnce\":true}]}\n~Lv2~{\"Name\":\"外圈4-8 10 2\",\"Group\":\"\",\"ZoneLockH\":[1122],\"DCond\":5,\"ElementsL\":[{\"Name\":\"\",\"refX\":88.794495,\"refY\":111.25071,\"refZ\":1.9073432E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.33897,\"refY\":111.29791,\"refZ\":1.9073432E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":88.71993,\"refY\":88.526566,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.38,\"refY\":88.68,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":88.25556,\"refY\":106.205,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4278198527,\"thicc\":5.0},{\"Name\":\"\",\"refX\":93.796,\"refY\":88.645,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4278198527,\"thicc\":5.0},{\"Name\":\"\",\"refX\":106.276,\"refY\":111.385,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4278198527,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.376,\"refY\":93.965,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4278198527,\"thicc\":5.0}],\"UseTriggers\":true,\"Triggers\":[{\"Type\":2,\"Duration\":4.0,\"Match\":\"(12256>31651)\",\"MatchDelay\":12.0,\"FireOnce\":true}]}\n~Lv2~{\"Name\":\"外圈8 10 3\",\"Group\":\"\",\"ZoneLockH\":[1122],\"DCond\":5,\"ElementsL\":[{\"Name\":\"\",\"refX\":88.794495,\"refY\":111.25071,\"refZ\":1.9073432E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":88.6255,\"refY\":99.7109,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":88.71993,\"refY\":88.526566,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":99.95172,\"refY\":88.80651,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.38,\"refY\":88.68,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.35302,\"refY\":100.24613,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.33897,\"refY\":111.29791,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":99.82139,\"refY\":111.19131,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0}],\"UseTriggers\":true,\"Triggers\":[{\"Type\":2,\"Duration\":2.0,\"Match\":\"(12256>31651)\",\"MatchDelay\":16.0,\"FireOnce\":true}]}\n~Lv2~{\"Name\":\"中等8 10 4\",\"Group\":\"\",\"ZoneLockH\":[1122],\"DCond\":5,\"ElementsL\":[{\"Name\":\"\",\"refX\":91.37199,\"refY\":108.556305,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":91.44375,\"refY\":99.60707,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":99.979904,\"refY\":108.693306,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":108.53327,\"refY\":108.60849,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":108.60915,\"refY\":100.237564,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":108.661934,\"refY\":91.29651,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":100.09634,\"refY\":91.56524,\"refZ\":1.9073432E-06,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":91.39042,\"refY\":91.31222,\"refZ\":9.5366886E-07,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0}],\"UseTriggers\":true,\"Triggers\":[{\"Type\":2,\"Duration\":2.0,\"Match\":\"(12256>31651)\",\"MatchDelay\":18.0,\"FireOnce\":true}]} ".Split("\n");

            var exasquaresOut = "~Lv2~{\"Name\":\"外圈4 0 1\",\"Group\":\"\",\"ZoneLockH\":[1122],\"DCond\":5,\"ElementsL\":[{\"Name\":\"\",\"refX\":88.794495,\"refY\":111.25071,\"refZ\":1.9073432E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":88.71993,\"refY\":88.526566,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.38,\"refY\":88.68,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.33897,\"refY\":111.29791,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0}],\"UseTriggers\":true,\"Triggers\":[{\"Type\":2,\"Duration\":4.0,\"Match\":\"(12256>31651)\",\"MatchDelay\":8.0,\"FireOnce\":true}]}\n~Lv2~{\"Name\":\"中等4 0 2\",\"Group\":\"\",\"ZoneLockH\":[1122],\"DCond\":5,\"ElementsL\":[{\"Name\":\"\",\"refX\":92.1682,\"refY\":107.631645,\"refZ\":1.9073432E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":107.97288,\"refY\":108.00102,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":108.01027,\"refY\":91.93993,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":92.052635,\"refY\":92.02039,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0}],\"UseTriggers\":true,\"Triggers\":[{\"Type\":2,\"Duration\":2.0,\"Match\":\"(12256>31651)\",\"MatchDelay\":12.0,\"FireOnce\":true}]}\n~Lv2~{\"Name\":\"外圈8 0 3\",\"Group\":\"\",\"ZoneLockH\":[1122],\"DCond\":5,\"ElementsL\":[{\"Name\":\"\",\"refX\":88.794495,\"refY\":111.25071,\"refZ\":1.9073432E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":88.6255,\"refY\":99.7109,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":88.71993,\"refY\":88.526566,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":99.95172,\"refY\":88.80651,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.38,\"refY\":88.68,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.35302,\"refY\":100.24613,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":111.33897,\"refY\":111.29791,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":99.82139,\"refY\":111.19131,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0}],\"UseTriggers\":true,\"Triggers\":[{\"Type\":2,\"Duration\":2.0,\"Match\":\"(12256>31651)\",\"MatchDelay\":14.0,\"FireOnce\":true}]}\n~Lv2~{\"Name\":\"中等8 0 4\",\"Group\":\"\",\"ZoneLockH\":[1122],\"DCond\":5,\"ElementsL\":[{\"Name\":\"\",\"refX\":91.37199,\"refY\":108.556305,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":91.44375,\"refY\":99.60707,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":99.979904,\"refY\":108.693306,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":108.53327,\"refY\":108.60849,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":108.60915,\"refY\":100.237564,\"refZ\":-5.456968E-12,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":108.661934,\"refY\":91.29651,\"refZ\":-1.907354E-06,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0},{\"Name\":\"\",\"refX\":100.09634,\"refY\":91.56524,\"refZ\":1.9073432E-06,\"radius\":0.9,\"color\":4278205183,\"thicc\":5.0},{\"Name\":\"\",\"refX\":91.39042,\"refY\":91.31222,\"refZ\":9.5366886E-07,\"radius\":0.9,\"color\":4293459712,\"thicc\":5.0}],\"UseTriggers\":true,\"Triggers\":[{\"Type\":2,\"Duration\":2.0,\"Match\":\"(12256>31651)\",\"MatchDelay\":16.0,\"FireOnce\":true}]} ".Split("\n");

            for (int i = 0; i < exasquaresIn.Length; i++)
            {
                if (!Controller.TryRegisterLayoutFromCode($"In{i}", exasquaresIn[i], out _)) PluginLog.Error("Error");
            }

            for (int i = 0; i < exasquaresOut.Length; i++)
            {
                if (!Controller.TryRegisterLayoutFromCode($"Out{i}", exasquaresOut[i], out _)) PluginLog.Error("Error");
            }
            Off();
        }

        void Reset()
        {
            mechanicResolved = false;
            Controller.ClearRegisteredLayouts();
            this.OnSetup();
            Controller.ApplyOverrides();
        }

        public override void OnMessage(string Message)
        {
            if (Controller.Scene == 7)
            {
                if (Message.Contains("(12256>31651)"))
                {
                    var npc = Svc.Objects.Where(x => x is BattleChara b && b.CastActionId == 31651);
                    if (npc.Any() && !mechanicResolved)
                    {
                        sch?.Dispose();
                        sch = new TickScheduler(Reset, 40000);
                        mechanicResolved = true;
                        if (!npc.Any(x => x.Position.X.InRange(99f, 101f) || x.Position.Y.InRange(99f, 101f)))
                        {
                            DisplayOUT();
                        }
                        else
                        {
                            DisplayIN();
                        }
                    }
                }
            }
            else
            {
                mechanicResolved = false;
            }
        }

        public override void OnDirectorUpdate(DirectorUpdateCategory category)
        {
            if(category.EqualsAny(DirectorUpdateCategory.Wipe, DirectorUpdateCategory.Commence, DirectorUpdateCategory.Recommence))
            {
                sch?.Dispose();
            }
        }

        void Off()
        {
            Controller.GetRegisteredLayouts().Each(x => x.Value.Enabled = false);
        }

        void DisplayIN()
        {
            Off();
            Controller.GetRegisteredLayouts().Each(x => x.Value.ElementsL.Each((z) => { z.color = Controller.GetConfig<Config>().Col.ToUint(); z.FillStep = Controller.GetConfig<Config>().FillStep; }));
            Controller.GetRegisteredLayouts().Where(x => x.Key.Contains("In")).Each(x => x.Value.Enabled = true);
        }

        void DisplayOUT()
        {
            Off();
            Controller.GetRegisteredLayouts().Each(x => x.Value.ElementsL.Each((z) => { z.color = Controller.GetConfig<Config>().Col.ToUint(); z.FillStep = Controller.GetConfig<Config>().FillStep; }));
            Controller.GetRegisteredLayouts().Where(x => x.Key.Contains("Out")).Each(x => x.Value.Enabled = true);
        }

        public override void OnSettingsDraw()
        {
            var c = Controller.GetConfig<Config>();
            ImGui.SetNextItemWidth(400f);
            ImGui.ColorEdit4("Color", ref c.Col);
            ImGui.SetNextItemWidth(60f);
            ImGui.DragFloat("Fill step", ref c.FillStep, 0.01f, 0.01f, 10);
        }

        public class Config : IEzConfig
        {
            public Vector4 Col = ImGuiColors.DalamudRed;
            public float FillStep = 0.5f;
        }
    }
}
