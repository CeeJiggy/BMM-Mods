using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using Flash2;
using UnhollowerRuntimeLib;


namespace CharacterSounds
{
    public static class Main
    {
        public static void OnModLoad()
        {
            Chara.kHasVoiceCharaBottom = Chara.eKind.Dreamcast;

            //Kiryu
            { sound_id.cuesheet vo_kiryu = (sound_id.cuesheet)101;
                sound_id.cue vo_kiryu_start = (sound_id.cue)839;
                sound_id.cue vo_kiryu_happy = (sound_id.cue)840;
                sound_id.cue vo_kiryu_yabai = (sound_id.cue)841;
                sound_id.cue vo_kiryu_fallout = (sound_id.cue)842;
                sound_id.cue vo_kiryu_timeover = (sound_id.cue)843;
                sound_id.cue vo_kiryu_goal01 = (sound_id.cue)844;
                sound_id.cue vo_kiryu_goal02 = (sound_id.cue)845;
                sound_id.cue vo_kiryu_goal03 = (sound_id.cue)846;
                sound_id.cue vo_kiryu_goal_fly = (sound_id.cue)847;
                sound_id.cue vo_kiryu_hanauta = (sound_id.cue)848;
                sound_id.cue vo_kiryu_thankyou = (sound_id.cue)849;
                sound_id.cue vo_kiryu_continue_select = (sound_id.cue)850;
                sound_id.cue vo_kiryu_continue_unselect = (sound_id.cue)851;
                sound_id.cue vo_kiryu_gakkari = (sound_id.cue)852;
                sound_id.cue vo_kiryu_yabai_long = (sound_id.cue)853;
                sound_id.cue vo_kiryu_happy_long = (sound_id.cue)854;
                sound_id.cue vo_kiryu_happy01 = (sound_id.cue)855;
                sound_id.cue vo_kiryu_happy02 = (sound_id.cue)856;
                sound_id.cue vo_kiryu_happy03 = (sound_id.cue)857;
                sound_id.cue vo_kiryu_yabai01 = (sound_id.cue)858;
                sound_id.cue vo_kiryu_yabai02 = (sound_id.cue)859;
                sound_id.cue vo_kiryu_yabai03 = (sound_id.cue)860;
                sound_id.cue vo_kiryu_happy_long01 = (sound_id.cue)861;
                sound_id.cue vo_kiryu_happy_long02 = (sound_id.cue)862; 
            }
            //Sonic
            {
                sound_id.cuesheet vo_sonic = (sound_id.cuesheet)102;
                sound_id.cue vo_sonic_start = (sound_id.cue)862;
                sound_id.cue vo_sonic_happy = (sound_id.cue)863;
                sound_id.cue vo_sonic_yabai = (sound_id.cue)864;
                sound_id.cue vo_sonic_fallout = (sound_id.cue)865;
                sound_id.cue vo_sonic_timeover = (sound_id.cue)866;
                sound_id.cue vo_sonic_goal01 = (sound_id.cue)867;
                sound_id.cue vo_sonic_goal02 = (sound_id.cue)868;
                sound_id.cue vo_sonic_goal03 = (sound_id.cue)869;
                sound_id.cue vo_sonic_goal_fly = (sound_id.cue)870;
                sound_id.cue vo_sonic_hanauta = (sound_id.cue)871;
                sound_id.cue vo_sonic_thankyou = (sound_id.cue)872;
                sound_id.cue vo_sonic_continue_select = (sound_id.cue)873;
                sound_id.cue vo_sonic_continue_unselect = (sound_id.cue)874;
                sound_id.cue vo_sonic_gakkari = (sound_id.cue)875;
                sound_id.cue vo_sonic_yabai_long = (sound_id.cue)876;
                sound_id.cue vo_sonic_happy_long = (sound_id.cue)877;
                sound_id.cue vo_sonic_happy01 = (sound_id.cue)878;
                sound_id.cue vo_sonic_happy02 = (sound_id.cue)879;
                sound_id.cue vo_sonic_happy03 = (sound_id.cue)880;
                sound_id.cue vo_sonic_yabai01 = (sound_id.cue)881;
                sound_id.cue vo_sonic_yabai02 = (sound_id.cue)882;
                sound_id.cue vo_sonic_yabai03 = (sound_id.cue)883;
                sound_id.cue vo_sonic_happy_long01 = (sound_id.cue)884;
                sound_id.cue vo_sonic_happy_long02 = (sound_id.cue)885;
            }
        }
    }
}
