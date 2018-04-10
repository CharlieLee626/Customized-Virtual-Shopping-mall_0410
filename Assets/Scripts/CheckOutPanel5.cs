using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckOutPanel5 : MonoBehaviour
{

    public Dictionary<Item.Type, GameObject> ItemBlocks = new Dictionary<Item.Type, GameObject>();
    public Dictionary<Item.Type, Sprite> ItemsImage = new Dictionary<Item.Type, Sprite>();
    public Dictionary<Item.Type, string> ItemsName = new Dictionary<Item.Type, string>();
    public GameObject ItemBlock;
    public static CheckOutPanel5 Instance;
    //public Sprite test;

    public GameObject checkout_label;

    public void CheckOut()
    {
        print("CHECK OUT SUCCESS!");
        checkout_label.SetActive(true);
    }

    public void ChangeScene()
    {
        //SceneManager.LoadScene("ChangeScene");
        //next_Canvas_toBe_Shown.SetActive(true);


    }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        //Assign String
        ItemsName.Add(Item.Type.shoe, "Nike AirMax");
        ItemsName.Add(Item.Type.blacksneaker, "Adidas Boost");
        ItemsName.Add(Item.Type.cap, "Nike Cap");
        ItemsName.Add(Item.Type.sunglasses, "RayBan Sunglasses");
        ItemsName.Add(Item.Type.sportsunglasses, "Sport Sunglasses");
        ItemsName.Add(Item.Type.flashlight, "FlashLight");
        ItemsName.Add(Item.Type.cat, "Cat Doll");
        ItemsName.Add(Item.Type.knife, "Knife");
        ItemsName.Add(Item.Type.kiwi, "Kiwi");
        ItemsName.Add(Item.Type.pear, "Pear");
        ItemsName.Add(Item.Type.apple, "Apple");
        ItemsName.Add(Item.Type.banana, "Banana");
        ItemsName.Add(Item.Type.atomball, "AtomBall");
        ItemsName.Add(Item.Type.buckyball, "Buckyball");
        ItemsName.Add(Item.Type.boat, "Boat");
        ItemsName.Add(Item.Type.piano, "Piano");

        //Assign Sprite
        ItemsImage.Add(Item.Type.shoe, Resources.Load<Sprite>("ShoeImage"));
        ItemsImage.Add(Item.Type.blacksneaker, Resources.Load<Sprite>("BlackShoeImage"));
        ItemsImage.Add(Item.Type.cap, Resources.Load<Sprite>("CapImage"));
        ItemsImage.Add(Item.Type.sunglasses, Resources.Load<Sprite>("SunglassesImage"));
        ItemsImage.Add(Item.Type.sportsunglasses, Resources.Load<Sprite>("SportSunglassesImage"));
        ItemsImage.Add(Item.Type.flashlight, Resources.Load<Sprite>("flashlight"));
        ItemsImage.Add(Item.Type.cat, Resources.Load<Sprite>("cat"));
        ItemsImage.Add(Item.Type.knife, Resources.Load<Sprite>("knife"));
        //ItemsImage.Add(Item.Type.kiwi, Resources.Load<Sprite>("kiwi"));
        //ItemsImage.Add(Item.Type.pear, Resources.Load<Sprite>("pear"));
        //ItemsImage.Add(Item.Type.apple, Resources.Load<Sprite>("apple"));
        //ItemsImage.Add(Item.Type.banana, Resources.Load<Sprite>("banana"));
        ItemsImage.Add(Item.Type.atomball, Resources.Load<Sprite>("atomball"));
        ItemsImage.Add(Item.Type.buckyball, Resources.Load<Sprite>("buckyball"));
        ItemsImage.Add(Item.Type.boat, Resources.Load<Sprite>("boat"));
        ItemsImage.Add(Item.Type.piano, Resources.Load<Sprite>("piano"));


        //store1 3c assign string
        ItemsName.Add(Item.Type.smartphone, "Cellphone");
        ItemsName.Add(Item.Type.blackkeyboard, "Wireless Keyboard");
        ItemsName.Add(Item.Type.blackmouse, "Mouse Black");
        ItemsName.Add(Item.Type.tv, "40' TV");
        ItemsName.Add(Item.Type.speaker, "Speaker");
        ItemsName.Add(Item.Type.pc_speaker, "PC Speaker");
        ItemsName.Add(Item.Type.desktop, "Desktop");
        ItemsName.Add(Item.Type.whitenotebook, "ASUS Thin Laptop");
        ItemsName.Add(Item.Type.whitemouse, "Mouse Gray");
        ItemsName.Add(Item.Type.monitor, "22' Moniter");
        ItemsName.Add(Item.Type.whitekeyboard, "Wired keyboard");
        ItemsName.Add(Item.Type.goldlaptop, "Acer New Laptop");
        ItemsName.Add(Item.Type.macbook, "Apple Macbook");
        //store 3c assign sprite
        ItemsImage.Add(Item.Type.smartphone, Resources.Load<Sprite>("1_smartphone"));
        ItemsImage.Add(Item.Type.blackkeyboard, Resources.Load<Sprite>("1_blackkeyboard"));
        ItemsImage.Add(Item.Type.blackmouse, Resources.Load<Sprite>("1_blackmouse"));
        ItemsImage.Add(Item.Type.tv, Resources.Load<Sprite>("1_tv"));
        ItemsImage.Add(Item.Type.speaker, Resources.Load<Sprite>("1_speaker"));
        ItemsImage.Add(Item.Type.pc_speaker, Resources.Load<Sprite>("1_pcspeaker"));
        ItemsImage.Add(Item.Type.desktop, Resources.Load<Sprite>("1_desktop"));
        ItemsImage.Add(Item.Type.whitenotebook, Resources.Load<Sprite>("1_whitenotebook"));
        ItemsImage.Add(Item.Type.whitemouse, Resources.Load<Sprite>("1_whitemouse"));
        ItemsImage.Add(Item.Type.monitor, Resources.Load<Sprite>("1_monitor"));
        ItemsImage.Add(Item.Type.whitekeyboard, Resources.Load<Sprite>("1_whitekeyboard"));
        ItemsImage.Add(Item.Type.goldlaptop, Resources.Load<Sprite>("1_goldlaptop"));
        ItemsImage.Add(Item.Type.macbook, Resources.Load<Sprite>("1_macbook"));

        //store2 sport assign string
        ItemsName.Add(Item.Type.punchingbag, "Punching Bag");
        ItemsName.Add(Item.Type.paddleyellow, "Table Tennis Bat Yellow");
        ItemsName.Add(Item.Type.paddleblue, "Table Tennis Bat Blue");
        ItemsName.Add(Item.Type.gloves, "Boxing Glove");
        ItemsName.Add(Item.Type.dirtyfootball, "Football 1");
        ItemsName.Add(Item.Type.basketballlight, "Basketball 1");
        ItemsName.Add(Item.Type.darkvolleyball, "Volleyball 1");
        ItemsName.Add(Item.Type.tabletennis, "Table Tennis Ball");
        ItemsName.Add(Item.Type.rugby, "Rugby Ball");
        ItemsName.Add(Item.Type.golfball, "Golf Ball 1");
        ItemsName.Add(Item.Type.basketball, "Basket Ball 2");
        ItemsName.Add(Item.Type.volleyball_py, "Volley Ball 2");
        ItemsName.Add(Item.Type.volleyball_y, "Volley Ball Yellow");
        ItemsName.Add(Item.Type.volleyball_leather, "Volley Ball Leather");
        ItemsName.Add(Item.Type.volleyball_white, "Volley Ball White");
        ItemsName.Add(Item.Type.volleyball_yb, "Volley Ball 3");
        ItemsName.Add(Item.Type.tennisball, "Tennis Ball");
        ItemsName.Add(Item.Type.golfball_b, "Fluorescent Golf Ball");
        ItemsName.Add(Item.Type.golfball_a, "Golf Ball 2");
        ItemsName.Add(Item.Type.football_yellow, "Football 2");
        ItemsName.Add(Item.Type.football_dirty, "Football 3");
        ItemsName.Add(Item.Type.football_red, "Football Red");
        ItemsName.Add(Item.Type.football_white, "Football White");
        ItemsName.Add(Item.Type.football_origin, "Football 4");
        ItemsName.Add(Item.Type.basketball_girl, "Women Basketball");
        ItemsName.Add(Item.Type.basketball_street, "Basketball 3");
        ItemsName.Add(Item.Type.basketball_black, "Basketball Black");
        ItemsName.Add(Item.Type.basketball_wob, "Badketball 4");
        ItemsName.Add(Item.Type.basketball_origin, "Basketball 5");
        ItemsName.Add(Item.Type.bodyboard_stripe, "Bodyboard Sprite");
        ItemsName.Add(Item.Type.bodyboard_green, "Bodyboard Green");
        ItemsName.Add(Item.Type.bodyboard_ocean, "Bodyboard White");
        ItemsName.Add(Item.Type.bodyboard_red, "Bodyboard Red");
        ItemsName.Add(Item.Type.bodyboard_blue, "Bodyboard Blue");
        ItemsName.Add(Item.Type.beachbat_y, "Beach Bat Yellow");
        ItemsName.Add(Item.Type.beachbat_stripe, "Beach Bat Stripe");
        //store2 sport assign sprite
        ItemsImage.Add(Item.Type.punchingbag, Resources.Load<Sprite>("2_punchingbag"));
        ItemsImage.Add(Item.Type.paddleyellow, Resources.Load<Sprite>("2_paddleyellow"));
        ItemsImage.Add(Item.Type.paddleblue, Resources.Load<Sprite>("2_paddleblue"));
        ItemsImage.Add(Item.Type.gloves, Resources.Load<Sprite>("2_gloves"));
        ItemsImage.Add(Item.Type.dirtyfootball, Resources.Load<Sprite>("2_dirtyfootball"));
        ItemsImage.Add(Item.Type.basketballlight, Resources.Load<Sprite>("2_basketballlight"));
        ItemsImage.Add(Item.Type.darkvolleyball, Resources.Load<Sprite>("2_darkvolleyball"));
        ItemsImage.Add(Item.Type.tabletennis, Resources.Load<Sprite>("2_tabletennis"));
        ItemsImage.Add(Item.Type.rugby, Resources.Load<Sprite>("2_rugby"));
        ItemsImage.Add(Item.Type.golfball, Resources.Load<Sprite>("2_golfball"));
        ItemsImage.Add(Item.Type.basketball, Resources.Load<Sprite>("2_basketball"));
        ItemsImage.Add(Item.Type.volleyball_py, Resources.Load<Sprite>("2_volleyballpy"));
        ItemsImage.Add(Item.Type.volleyball_y, Resources.Load<Sprite>("2_volleybally"));
        ItemsImage.Add(Item.Type.volleyball_leather, Resources.Load<Sprite>("2_volleyballleather"));
        ItemsImage.Add(Item.Type.volleyball_white, Resources.Load<Sprite>("2_volleyballwhite"));
        ItemsImage.Add(Item.Type.volleyball_yb, Resources.Load<Sprite>("2_volleyballyb"));
        ItemsImage.Add(Item.Type.tennisball, Resources.Load<Sprite>("2_tennisball"));
        ItemsImage.Add(Item.Type.golfball_b, Resources.Load<Sprite>("2_golfballb"));
        ItemsImage.Add(Item.Type.golfball_a, Resources.Load<Sprite>("2_golfballa"));
        ItemsImage.Add(Item.Type.football_yellow, Resources.Load<Sprite>("2_footballyellow"));
        ItemsImage.Add(Item.Type.football_dirty, Resources.Load<Sprite>("2_footballdirty"));
        ItemsImage.Add(Item.Type.football_red, Resources.Load<Sprite>("2_footballred"));
        ItemsImage.Add(Item.Type.football_white, Resources.Load<Sprite>("2_footballwhite"));
        ItemsImage.Add(Item.Type.football_origin, Resources.Load<Sprite>("2_footballorigin"));
        ItemsImage.Add(Item.Type.basketball_girl, Resources.Load<Sprite>("2_basketballgirl"));
        ItemsImage.Add(Item.Type.basketball_street, Resources.Load<Sprite>("2_basketballstreet"));
        ItemsImage.Add(Item.Type.basketball_black, Resources.Load<Sprite>("2_basketballblack"));
        ItemsImage.Add(Item.Type.basketball_wob, Resources.Load<Sprite>("2_basketballwob"));
        ItemsImage.Add(Item.Type.basketball_origin, Resources.Load<Sprite>("2_basketballorigin"));
        ItemsImage.Add(Item.Type.bodyboard_stripe, Resources.Load<Sprite>("2_bodyboardstripe"));
        ItemsImage.Add(Item.Type.bodyboard_green, Resources.Load<Sprite>("2_bodyboardgreen"));
        ItemsImage.Add(Item.Type.bodyboard_ocean, Resources.Load<Sprite>("2_bodyboardocean"));
        ItemsImage.Add(Item.Type.bodyboard_red, Resources.Load<Sprite>("2_bodyboardred"));
        ItemsImage.Add(Item.Type.bodyboard_blue, Resources.Load<Sprite>("2_bodyboardblue"));
        ItemsImage.Add(Item.Type.beachbat_y, Resources.Load<Sprite>("2_beachbaty"));
        ItemsImage.Add(Item.Type.beachbat_stripe, Resources.Load<Sprite>("2_beachbatstripe"));

        //store3 outdoor assign string
        ItemsName.Add(Item.Type.tent_bag, "Tent Bag");
        ItemsName.Add(Item.Type.survival_food, "Survival Food");
        ItemsName.Add(Item.Type.shovel, "Shovel");
        ItemsName.Add(Item.Type.pillow_bottle, "Pillow Bottle");
        ItemsName.Add(Item.Type.match_box, "Match Box");
        ItemsName.Add(Item.Type.knife_outdoor, "Knife");
        ItemsName.Add(Item.Type.flask, "Flask");
        ItemsName.Add(Item.Type.flashlight_small, "Flash Light Small");
        ItemsName.Add(Item.Type.ducktape, "Ducktape");
        ItemsName.Add(Item.Type.compass, "Compass");
        ItemsName.Add(Item.Type.can_red, "Tomato Can");
        ItemsName.Add(Item.Type.can_blue, "Pea Stew Can");
        ItemsName.Add(Item.Type.can_green, "Ministrone Can");
        ItemsName.Add(Item.Type.book_b, "Medical Guide");
        ItemsName.Add(Item.Type.book_o, "Survival Guide");
        ItemsName.Add(Item.Type.binoculars, "Binoculars");
        ItemsName.Add(Item.Type.battery_small, "Battery AAA");
        ItemsName.Add(Item.Type.battery_big, "Battery AA");
        ItemsName.Add(Item.Type.axe_small, "Axe 1");
        ItemsName.Add(Item.Type.axe_large, "Axe 2");
        ItemsName.Add(Item.Type.boiling_pot, "Boiling Pot");
        ItemsName.Add(Item.Type.frying_pan, "Frying Pan");
        ItemsName.Add(Item.Type.tea_pot, "Tea Pot");
        //store3 outdoor assign sprite
        ItemsImage.Add(Item.Type.tent_bag, Resources.Load<Sprite>("3_tentbag"));
        ItemsImage.Add(Item.Type.survival_food, Resources.Load<Sprite>("3_survivalfood"));
        ItemsImage.Add(Item.Type.shovel, Resources.Load<Sprite>("3_shovel"));
        ItemsImage.Add(Item.Type.pillow_bottle, Resources.Load<Sprite>("3_pillowbottle"));
        ItemsImage.Add(Item.Type.match_box, Resources.Load<Sprite>("3_matchbox"));
        ItemsImage.Add(Item.Type.knife_outdoor, Resources.Load<Sprite>("3_knifeoutdoor"));
        ItemsImage.Add(Item.Type.flask, Resources.Load<Sprite>("3_flask"));
        ItemsImage.Add(Item.Type.flashlight_small, Resources.Load<Sprite>("3_flashlightsmall"));
        ItemsImage.Add(Item.Type.ducktape, Resources.Load<Sprite>("3_ducktape"));
        ItemsImage.Add(Item.Type.compass, Resources.Load<Sprite>("3_compass"));
        ItemsImage.Add(Item.Type.can_red, Resources.Load<Sprite>("3_canred"));
        ItemsImage.Add(Item.Type.can_blue, Resources.Load<Sprite>("3_canblue"));
        ItemsImage.Add(Item.Type.can_green, Resources.Load<Sprite>("3_cangreen"));
        ItemsImage.Add(Item.Type.book_b, Resources.Load<Sprite>("3_bookb"));
        ItemsImage.Add(Item.Type.book_o, Resources.Load<Sprite>("3_booko"));
        ItemsImage.Add(Item.Type.binoculars, Resources.Load<Sprite>("3_binoculars"));
        ItemsImage.Add(Item.Type.battery_small, Resources.Load<Sprite>("3_batterysmall"));
        ItemsImage.Add(Item.Type.battery_big, Resources.Load<Sprite>("3_batterybig"));
        ItemsImage.Add(Item.Type.axe_small, Resources.Load<Sprite>("3_axesmall"));
        ItemsImage.Add(Item.Type.axe_large, Resources.Load<Sprite>("3_axelarge"));
        ItemsImage.Add(Item.Type.boiling_pot, Resources.Load<Sprite>("3_boilingpot"));
        ItemsImage.Add(Item.Type.frying_pan, Resources.Load<Sprite>("3_fryingpan"));
        ItemsImage.Add(Item.Type.tea_pot, Resources.Load<Sprite>("3_teapot"));

        //store4 home assign string
        ItemsName.Add(Item.Type.sledge_hammer, "Hammer 1");
        ItemsName.Add(Item.Type.ice_axe, "Axe 3");
        ItemsName.Add(Item.Type.hammer_black, "Hammer 2");
        ItemsName.Add(Item.Type.hacksaw, "Hacksaw");
        ItemsName.Add(Item.Type.crowbar_red, "Crowbar Red");
        ItemsName.Add(Item.Type.axe_darkwood, "Axe 4");
        ItemsName.Add(Item.Type.screwdriver, "Screwdriver");
        ItemsName.Add(Item.Type.saw, "Saw");
        ItemsName.Add(Item.Type.hammer_small, "Hammer 3");
        ItemsName.Add(Item.Type.box, "Box");
        ItemsName.Add(Item.Type.axe_lightwood, "Axe 5");
        ItemsName.Add(Item.Type.spoon, "Spoon 1");
        ItemsName.Add(Item.Type.soup_plate, "Soup Plate");
        ItemsName.Add(Item.Type.saucer, "Saucer");
        ItemsName.Add(Item.Type.saucepan, "Saucepan");
        ItemsName.Add(Item.Type.plate, "Plate 1");
        ItemsName.Add(Item.Type.pan, "Pan 1");
        ItemsName.Add(Item.Type.mug, "Mug");
        ItemsName.Add(Item.Type.ladle, "Ladle");
        ItemsName.Add(Item.Type.knife_home_big, "Knife 2");
        ItemsName.Add(Item.Type.fork, "Fork");
        ItemsName.Add(Item.Type.plastic_spoon, "Spoon 2");
        ItemsName.Add(Item.Type.cup, "Cup");
        ItemsName.Add(Item.Type.bowl, "Bowl");
        ItemsName.Add(Item.Type.pillow4_maya, "Pillow 4");
        ItemsName.Add(Item.Type.pillow7_red, "Pillow 7");
        ItemsName.Add(Item.Type.pillow6_patrick_star_give_me_the_hat_will_you, "Pillow 6");
        ItemsName.Add(Item.Type.pillow5_grey, "Pillow 5");
        ItemsName.Add(Item.Type.pillow3_white, "Pillow 3");
        ItemsName.Add(Item.Type.pillow1_militery, "Pillow 1");
        ItemsName.Add(Item.Type.pillow_long_stripe, "Pillow 8");
        ItemsName.Add(Item.Type.pillow_long_red, "Pillow 9");
        ItemsName.Add(Item.Type.pillow_long_white, "Pillow 10");
        ItemsName.Add(Item.Type.water_can_red, "Water Can Red");
        ItemsName.Add(Item.Type.water_can_green, "Water Can Green");
        ItemsName.Add(Item.Type.water_can_blue, "Water Can Blue");
        ItemsName.Add(Item.Type.wheel_barrow, "Wheel Barrow");
        ItemsName.Add(Item.Type.water_can_grey, "Water Can Grey");
        ItemsName.Add(Item.Type.spanner, "Spanner");
        ItemsName.Add(Item.Type.plastic_spork, "Plastic Spork");
        ItemsName.Add(Item.Type.rake, "Rake");
        ItemsName.Add(Item.Type.prong, "Prong");
        ItemsName.Add(Item.Type.table_fork, "Table Fork");
        ItemsName.Add(Item.Type.table_spoon, "Table Spoon");
        ItemsName.Add(Item.Type.coffee_table_dark, "Wood Coffee Table Dark");
        ItemsName.Add(Item.Type.metal_stool, "Metal Stool");
        ItemsName.Add(Item.Type.plunger, "Plunger");
        ItemsName.Add(Item.Type.cylinder_brush, "Cylinder Brush");
        ItemsName.Add(Item.Type.crowbar, "Crowbar 2");
        ItemsName.Add(Item.Type.chisel, "Chisel");
        ItemsName.Add(Item.Type.bucket, "Bucket");
        ItemsName.Add(Item.Type.broom, "Broom");
        ItemsName.Add(Item.Type.coffee_table_GG, "Wood Coffee Table");
        ItemsName.Add(Item.Type.coffee_table3, "Coffee Table");
        //store4 home assign stripe
        ItemsImage.Add(Item.Type.sledge_hammer, Resources.Load<Sprite>("4_sledgehammer"));
        ItemsImage.Add(Item.Type.ice_axe, Resources.Load<Sprite>("4_iceaxe"));
        ItemsImage.Add(Item.Type.hammer_black, Resources.Load<Sprite>("4_hammerbalck"));
        ItemsImage.Add(Item.Type.hacksaw, Resources.Load<Sprite>("4_hacksaw"));
        ItemsImage.Add(Item.Type.crowbar_red, Resources.Load<Sprite>("4_crowbarred"));
        ItemsImage.Add(Item.Type.axe_darkwood, Resources.Load<Sprite>("4_axedarkwood"));
        ItemsImage.Add(Item.Type.screwdriver, Resources.Load<Sprite>("4_screwdriver"));
        ItemsImage.Add(Item.Type.saw, Resources.Load<Sprite>("4_saw"));
        ItemsImage.Add(Item.Type.hammer_small, Resources.Load<Sprite>("4_hammersmall"));
        ItemsImage.Add(Item.Type.box, Resources.Load<Sprite>("4_box"));
        ItemsImage.Add(Item.Type.axe_lightwood, Resources.Load<Sprite>("4_axelightwood"));
        ItemsImage.Add(Item.Type.spoon, Resources.Load<Sprite>("4_spoon"));
        ItemsImage.Add(Item.Type.soup_plate, Resources.Load<Sprite>("4_soupplate"));
        ItemsImage.Add(Item.Type.saucer, Resources.Load<Sprite>("4_saucer"));
        ItemsImage.Add(Item.Type.saucepan, Resources.Load<Sprite>("4_saucepan"));
        ItemsImage.Add(Item.Type.plate, Resources.Load<Sprite>("4_plate"));
        ItemsImage.Add(Item.Type.pan, Resources.Load<Sprite>("4_pan"));
        ItemsImage.Add(Item.Type.mug, Resources.Load<Sprite>("4_mug"));
        ItemsImage.Add(Item.Type.ladle, Resources.Load<Sprite>("4_ladle"));
        ItemsImage.Add(Item.Type.knife_home_big, Resources.Load<Sprite>("4_knifehomebig"));
        ItemsImage.Add(Item.Type.fork, Resources.Load<Sprite>("4_fork"));
        ItemsImage.Add(Item.Type.plastic_spoon, Resources.Load<Sprite>("4_plasticspoon"));
        ItemsImage.Add(Item.Type.cup, Resources.Load<Sprite>("4_cup"));
        ItemsImage.Add(Item.Type.bowl, Resources.Load<Sprite>("4_bowl"));
        ItemsImage.Add(Item.Type.pillow4_maya, Resources.Load<Sprite>("4_pillow4maya"));
        ItemsImage.Add(Item.Type.pillow7_red, Resources.Load<Sprite>("4_pillow7red"));
        ItemsImage.Add(Item.Type.pillow6_patrick_star_give_me_the_hat_will_you, Resources.Load<Sprite>("4_pillow6patrickstargivemethehatwillyou"));
        ItemsImage.Add(Item.Type.pillow5_grey, Resources.Load<Sprite>("4_pillow5grey"));
        ItemsImage.Add(Item.Type.pillow3_white, Resources.Load<Sprite>("4_pillow3white"));
        ItemsImage.Add(Item.Type.pillow1_militery, Resources.Load<Sprite>("4_pillow1militery"));
        ItemsImage.Add(Item.Type.pillow_long_stripe, Resources.Load<Sprite>("4_pillowlongstripe"));
        ItemsImage.Add(Item.Type.pillow_long_red, Resources.Load<Sprite>("4_pillowlongred"));
        ItemsImage.Add(Item.Type.pillow_long_white, Resources.Load<Sprite>("4_pillowlongwhite"));
        ItemsImage.Add(Item.Type.water_can_red, Resources.Load<Sprite>("4_watercanred"));
        ItemsImage.Add(Item.Type.water_can_green, Resources.Load<Sprite>("4_watercangreen"));
        ItemsImage.Add(Item.Type.water_can_blue, Resources.Load<Sprite>("4_watercanblue"));
        ItemsImage.Add(Item.Type.wheel_barrow, Resources.Load<Sprite>("4_wheelbarrow"));
        ItemsImage.Add(Item.Type.water_can_grey, Resources.Load<Sprite>("4_watercangrey"));
        ItemsImage.Add(Item.Type.spanner, Resources.Load<Sprite>("4_spanner"));
        ItemsImage.Add(Item.Type.plastic_spork, Resources.Load<Sprite>("4_plasticspork"));
        ItemsImage.Add(Item.Type.rake, Resources.Load<Sprite>("4_rake"));
        ItemsImage.Add(Item.Type.prong, Resources.Load<Sprite>("4_prong"));
        ItemsImage.Add(Item.Type.table_fork, Resources.Load<Sprite>("4_tablefork"));
        ItemsImage.Add(Item.Type.table_spoon, Resources.Load<Sprite>("4_tablespoon"));
        ItemsImage.Add(Item.Type.coffee_table_dark, Resources.Load<Sprite>("4_coffeetabledark"));
        ItemsImage.Add(Item.Type.metal_stool, Resources.Load<Sprite>("4_metalstool"));
        ItemsImage.Add(Item.Type.plunger, Resources.Load<Sprite>("4_plunger"));
        ItemsImage.Add(Item.Type.cylinder_brush, Resources.Load<Sprite>("4_cylinderbrush"));
        ItemsImage.Add(Item.Type.crowbar, Resources.Load<Sprite>("4_crowbar"));
        ItemsImage.Add(Item.Type.chisel, Resources.Load<Sprite>("4_chisel"));
        ItemsImage.Add(Item.Type.bucket, Resources.Load<Sprite>("4_bucket"));
        ItemsImage.Add(Item.Type.broom, Resources.Load<Sprite>("4_broom"));
        ItemsImage.Add(Item.Type.coffee_table_GG, Resources.Load<Sprite>("4_coffeetablegg"));
        ItemsImage.Add(Item.Type.coffee_table3, Resources.Load<Sprite>("4_coffeetable3"));

        //store5 jewelry assign string
        ItemsName.Add(Item.Type.roundcut, "Diamond 1");
        ItemsName.Add(Item.Type.rosecut, "Diamond 2");
        ItemsName.Add(Item.Type.pearcut, "Diamond 3");
        ItemsName.Add(Item.Type.oldsinglecut, "Diamond 4");
        ItemsName.Add(Item.Type.schoolbag_3, "School Bag 3");
        ItemsName.Add(Item.Type.schoolbag_2, "School Bag 2");
        ItemsName.Add(Item.Type.schoolbag_1, "School Bag 1");
        ItemsName.Add(Item.Type.backpack_3, "BackPack 3");
        ItemsName.Add(Item.Type.backpack_2, "BackPack 2");
        ItemsName.Add(Item.Type.backpack_1, "BackPack 1");
        ItemsName.Add(Item.Type.object38, "Watch No. 38");
        ItemsName.Add(Item.Type.object36, "Watch No. 36");
        ItemsName.Add(Item.Type.object34, "Watch No. 34");
        ItemsName.Add(Item.Type.object32, "Watch No. 32");
        ItemsName.Add(Item.Type.object30, "Watch No. 30");
        ItemsName.Add(Item.Type.object24, "Watch No. 24");
        ItemsName.Add(Item.Type.object22, "Watch No. 22");
        ItemsName.Add(Item.Type.object16, "Watch No. 16");
        ItemsName.Add(Item.Type.object14, "Watch No. 14");
        ItemsName.Add(Item.Type.object26, "Watch No. 26");
        ItemsName.Add(Item.Type.object20, "Watch No. 20");
        ItemsName.Add(Item.Type.object18, "Watch No. 18");
        ItemsName.Add(Item.Type.object15, "Watch No. 15");
        ItemsName.Add(Item.Type.object10, "Watch No. 10");
        ItemsName.Add(Item.Type.object8, "Watch No. 8");
        ItemsName.Add(Item.Type.object6, "Watch No. 6");
        ItemsName.Add(Item.Type.object4, "Watch No. 4");
        ItemsName.Add(Item.Type.object99, "Watch No. 99");
        ItemsName.Add(Item.Type.object98, "Watch No. 98");
        ItemsName.Add(Item.Type.cylinder3, "Watch No. 3");
        ItemsName.Add(Item.Type.line32, "Glasses No. 32");
        ItemsName.Add(Item.Type.line30, "Glasses No. 30");
        ItemsName.Add(Item.Type.line28, "Glasses No. 28");
        ItemsName.Add(Item.Type.line26, "Glasses No. 26");
        ItemsName.Add(Item.Type.line24, "Glasses No. 24");
        ItemsName.Add(Item.Type.line22, "Glasses No. 22");
        ItemsName.Add(Item.Type.line20, "Glasses No. 20");
        ItemsName.Add(Item.Type.line18, "Glasses No. 18");
        ItemsName.Add(Item.Type.line17, "Glasses No. 17");
        ItemsName.Add(Item.Type.line16, "Glasses No. 16");
        ItemsName.Add(Item.Type.line15, "Glasses No. 15");
        ItemsName.Add(Item.Type.object003_2, "Jewelry 1");
        ItemsName.Add(Item.Type.object003_1, "Jewelry 2");
        ItemsName.Add(Item.Type.object003, "Jewelry 3");
        ItemsName.Add(Item.Type.object002_3, "Jewelry 4");
        ItemsName.Add(Item.Type.object002_2, "Jewelry 5");
        ItemsName.Add(Item.Type.object002, "Jewelry 6");
        ItemsName.Add(Item.Type.object001_2, "Jewelry 7");
        ItemsName.Add(Item.Type.line02_1, "Jewelry 8");
        ItemsName.Add(Item.Type.line02, "Jewelry 9");
        ItemsName.Add(Item.Type.suitcase11, "Suitcase No. 11");
        ItemsName.Add(Item.Type.suitcase9, "Suitcase No. 9");
        ItemsName.Add(Item.Type.suitcase8, "Suitcase No. 8");
        ItemsName.Add(Item.Type.suitcase6, "Suitcase No. 6");
        ItemsName.Add(Item.Type.suitcase5, "Suitcase No. 5");
        ItemsName.Add(Item.Type.briefcase13, "Briefcase No. 13");
        ItemsName.Add(Item.Type.briefcase12, "Briefcase No. 12");
        ItemsName.Add(Item.Type.briefcase11, "Briefcase No. 11");
        ItemsName.Add(Item.Type.briefcase10, "Briefcase No. 10");
        ItemsName.Add(Item.Type.briefcase7, "Briefcase No. 7");
        ItemsName.Add(Item.Type.briefcase6, "Briefcase No. 6");
        ItemsName.Add(Item.Type.briefcase5, "Briefcase No. 5");
        ItemsName.Add(Item.Type.briefcase3, "Briefcase No. 3");
        ItemsName.Add(Item.Type.bag24, "Bag No. 24");
        ItemsName.Add(Item.Type.bag23, "Bag No. 23");
        ItemsName.Add(Item.Type.bag22, "Bag No. 22");
        ItemsName.Add(Item.Type.bag21, "Bag No. 21");
        ItemsName.Add(Item.Type.bag20, "Bag No. 20");
        ItemsName.Add(Item.Type.bag19, "Bag No. 19");
        ItemsName.Add(Item.Type.bag18, "Bag No. 18");
        ItemsName.Add(Item.Type.bag17, "Bag No. 17");
        ItemsName.Add(Item.Type.bag16, "Bag No. 16");
        ItemsName.Add(Item.Type.bag15, "Bag No. 15");
        ItemsName.Add(Item.Type.bag12, "Bag No. 12");
        ItemsName.Add(Item.Type.bag11, "Bag No. 11");
        ItemsName.Add(Item.Type.bag10, "Bag No. 10");
        ItemsName.Add(Item.Type.bag9, "Bag No. 9");
        ItemsName.Add(Item.Type.bag8, "Bag No. 8");
        ItemsName.Add(Item.Type.bag4, "Bag No. 4");
        //store5 jewelry assign stripe
        ItemsImage.Add(Item.Type.roundcut, Resources.Load<Sprite>("5_roundcut"));
        ItemsImage.Add(Item.Type.rosecut, Resources.Load<Sprite>("5_rosecut"));
        ItemsImage.Add(Item.Type.pearcut, Resources.Load<Sprite>("5_pearcut"));
        ItemsImage.Add(Item.Type.oldsinglecut, Resources.Load<Sprite>("5_oldsinglecut"));
        ItemsImage.Add(Item.Type.schoolbag_3, Resources.Load<Sprite>("5_schoolbag3"));
        ItemsImage.Add(Item.Type.schoolbag_2, Resources.Load<Sprite>("5_schoolbag2"));
        ItemsImage.Add(Item.Type.schoolbag_1, Resources.Load<Sprite>("5_schoolbag1"));
        ItemsImage.Add(Item.Type.backpack_3, Resources.Load<Sprite>("5_backpack3"));
        ItemsImage.Add(Item.Type.backpack_2, Resources.Load<Sprite>("5_backpack2"));
        ItemsImage.Add(Item.Type.backpack_1, Resources.Load<Sprite>("5_backpack1"));
        ItemsImage.Add(Item.Type.object38, Resources.Load<Sprite>("5_object38"));
        ItemsImage.Add(Item.Type.object36, Resources.Load<Sprite>("5_object36"));
        ItemsImage.Add(Item.Type.object34, Resources.Load<Sprite>("5_object34"));
        ItemsImage.Add(Item.Type.object32, Resources.Load<Sprite>("5_object32"));
        ItemsImage.Add(Item.Type.object30, Resources.Load<Sprite>("5_object30"));
        ItemsImage.Add(Item.Type.object24, Resources.Load<Sprite>("5_object24"));
        ItemsImage.Add(Item.Type.object22, Resources.Load<Sprite>("5_object22"));
        ItemsImage.Add(Item.Type.object16, Resources.Load<Sprite>("5_object16"));
        ItemsImage.Add(Item.Type.object14, Resources.Load<Sprite>("5_object14"));
        ItemsImage.Add(Item.Type.object26, Resources.Load<Sprite>("5_object26"));
        ItemsImage.Add(Item.Type.object20, Resources.Load<Sprite>("5_object20"));
        ItemsImage.Add(Item.Type.object18, Resources.Load<Sprite>("5_object18"));
        ItemsImage.Add(Item.Type.object15, Resources.Load<Sprite>("5_object15"));
        ItemsImage.Add(Item.Type.object10, Resources.Load<Sprite>("5_object10"));
        ItemsImage.Add(Item.Type.object8, Resources.Load<Sprite>("5_object8"));
        ItemsImage.Add(Item.Type.object6, Resources.Load<Sprite>("5_object6"));
        ItemsImage.Add(Item.Type.object4, Resources.Load<Sprite>("5_object4"));
        ItemsImage.Add(Item.Type.object99, Resources.Load<Sprite>("5_object99"));
        ItemsImage.Add(Item.Type.object98, Resources.Load<Sprite>("5_object98"));
        ItemsImage.Add(Item.Type.cylinder3, Resources.Load<Sprite>("5_cylinder3"));
        ItemsImage.Add(Item.Type.line32, Resources.Load<Sprite>("5_line32"));
        ItemsImage.Add(Item.Type.line30, Resources.Load<Sprite>("5_line30"));
        ItemsImage.Add(Item.Type.line28, Resources.Load<Sprite>("5_line28"));
        ItemsImage.Add(Item.Type.line26, Resources.Load<Sprite>("5_line26"));
        ItemsImage.Add(Item.Type.line24, Resources.Load<Sprite>("5_line24"));
        ItemsImage.Add(Item.Type.line22, Resources.Load<Sprite>("5_line22"));
        ItemsImage.Add(Item.Type.line20, Resources.Load<Sprite>("5_line20"));
        ItemsImage.Add(Item.Type.line18, Resources.Load<Sprite>("5_line18"));
        ItemsImage.Add(Item.Type.line17, Resources.Load<Sprite>("5_line17"));
        ItemsImage.Add(Item.Type.line16, Resources.Load<Sprite>("5_line16"));
        ItemsImage.Add(Item.Type.line15, Resources.Load<Sprite>("5_line15"));
        ItemsImage.Add(Item.Type.object003_2, Resources.Load<Sprite>("5_object0032"));
        ItemsImage.Add(Item.Type.object003_1, Resources.Load<Sprite>("5_object0031"));
        ItemsImage.Add(Item.Type.object003, Resources.Load<Sprite>("5_object003"));
        ItemsImage.Add(Item.Type.object002_3, Resources.Load<Sprite>("5_object0023"));
        ItemsImage.Add(Item.Type.object002_2, Resources.Load<Sprite>("5_object0022"));
        ItemsImage.Add(Item.Type.object002, Resources.Load<Sprite>("5_object002"));
        ItemsImage.Add(Item.Type.object001_2, Resources.Load<Sprite>("5_object0012"));
        ItemsImage.Add(Item.Type.line02_1, Resources.Load<Sprite>("5_line021"));
        ItemsImage.Add(Item.Type.line02, Resources.Load<Sprite>("5_line02"));
        ItemsImage.Add(Item.Type.suitcase11, Resources.Load<Sprite>("5_suitcase11"));
        ItemsImage.Add(Item.Type.suitcase9, Resources.Load<Sprite>("5_suitcase9"));
        ItemsImage.Add(Item.Type.suitcase8, Resources.Load<Sprite>("5_suitcase8"));
        ItemsImage.Add(Item.Type.suitcase6, Resources.Load<Sprite>("5_suitcase6"));
        ItemsImage.Add(Item.Type.suitcase5, Resources.Load<Sprite>("5_suitcase5"));
        ItemsImage.Add(Item.Type.briefcase13, Resources.Load<Sprite>("5_briefcase13"));
        ItemsImage.Add(Item.Type.briefcase12, Resources.Load<Sprite>("5_briefcase12"));
        ItemsImage.Add(Item.Type.briefcase11, Resources.Load<Sprite>("5_briefcase11"));
        ItemsImage.Add(Item.Type.briefcase10, Resources.Load<Sprite>("5_briefcase10"));
        ItemsImage.Add(Item.Type.briefcase7, Resources.Load<Sprite>("5_briefcase7"));
        ItemsImage.Add(Item.Type.briefcase6, Resources.Load<Sprite>("5_briefcase6"));
        ItemsImage.Add(Item.Type.briefcase5, Resources.Load<Sprite>("5_briefcase5"));
        ItemsImage.Add(Item.Type.briefcase3, Resources.Load<Sprite>("5_briefcase3"));
        ItemsImage.Add(Item.Type.bag24, Resources.Load<Sprite>("5_bag24"));
        ItemsImage.Add(Item.Type.bag23, Resources.Load<Sprite>("5_bag23"));
        ItemsImage.Add(Item.Type.bag22, Resources.Load<Sprite>("5_bag22"));
        ItemsImage.Add(Item.Type.bag21, Resources.Load<Sprite>("5_bag21"));
        ItemsImage.Add(Item.Type.bag20, Resources.Load<Sprite>("5_bag20"));
        ItemsImage.Add(Item.Type.bag19, Resources.Load<Sprite>("5_bag19"));
        ItemsImage.Add(Item.Type.bag18, Resources.Load<Sprite>("5_bag18"));
        ItemsImage.Add(Item.Type.bag17, Resources.Load<Sprite>("5_bag17"));
        ItemsImage.Add(Item.Type.bag16, Resources.Load<Sprite>("5_bag16"));
        ItemsImage.Add(Item.Type.bag15, Resources.Load<Sprite>("5_bag15"));
        ItemsImage.Add(Item.Type.bag12, Resources.Load<Sprite>("5_bag12"));
        ItemsImage.Add(Item.Type.bag11, Resources.Load<Sprite>("5_bag11"));
        ItemsImage.Add(Item.Type.bag10, Resources.Load<Sprite>("5_bag10"));
        ItemsImage.Add(Item.Type.bag9, Resources.Load<Sprite>("5_bag9"));
        ItemsImage.Add(Item.Type.bag8, Resources.Load<Sprite>("5_bag8"));
        ItemsImage.Add(Item.Type.bag4, Resources.Load<Sprite>("5_bag4"));

        //store6 clothing assign string
        ItemsName.Add(Item.Type.hanging_tshirt_unity_white, "T-shirt Unity White");
        ItemsName.Add(Item.Type.tshirt_unity_yellow, "T-shirt Unity Yellow");
        ItemsName.Add(Item.Type.tshirt_studio_black, "T-shirt Studio Black");
        ItemsName.Add(Item.Type.hanging_tshirt_unity_red, "T-shirt Unity Red");
        ItemsName.Add(Item.Type.hanging_tshirt_unity_green, "T-shirt Unity Green");
        ItemsName.Add(Item.Type.hanging_tshirt_unity_blue, "T-shirt Unity Blue");
        ItemsName.Add(Item.Type.hanging_tshirt_unity_black, "T-shirt Unity Black");
        ItemsName.Add(Item.Type.folded_tshirt_yellow, "Folded T-shirt Yellow");
        ItemsName.Add(Item.Type.folded_tshirt_white, "Folded T-shirt White");
        ItemsName.Add(Item.Type.folded_tshirt_black, "Folded T-shirt Black");
        ItemsName.Add(Item.Type.folded_tshirt_studio, "Folded T-shirt Studio Black");
        ItemsName.Add(Item.Type.folded_tshirt_red, "Folded T-shirt Red");
        ItemsName.Add(Item.Type.folded_tshirt_pink, "Folded T-shirt Pink");
        ItemsName.Add(Item.Type.folded_tshirt_blue, "Folded T-shirt Blue");
        ItemsName.Add(Item.Type.trainers_white, "Trainers Shoe White");
        ItemsName.Add(Item.Type.trainers_green, "Trainers Shoe Green");
        ItemsName.Add(Item.Type.trainers_blue, "Trainers Shoe Blue");
        ItemsName.Add(Item.Type.trainers_black, "Trainers Shoe Black");
        ItemsName.Add(Item.Type.jeans_black, "Jeans Black");
        ItemsName.Add(Item.Type.jacket, "Jacket");
        ItemsName.Add(Item.Type.hat_yellow, "Hat Yellow");
        ItemsName.Add(Item.Type.hat_white, "Hat White");
        ItemsName.Add(Item.Type.hat_brown, "Hat Brown");
        ItemsName.Add(Item.Type.hat_blue, "Hat Blue");
        ItemsName.Add(Item.Type.hat_black, "Hat Black");
        ItemsName.Add(Item.Type.mens_shoe8, "Mens Shoe No.8");
        ItemsName.Add(Item.Type.mens_shoe7, "Mens Shoe No.7");
        ItemsName.Add(Item.Type.mens_shoe6, "Mens Shoe No.6");
        ItemsName.Add(Item.Type.mens_shoe5, "Mens Shoe No.5");
        ItemsName.Add(Item.Type.mens_shoe4, "Mens Shoe No.4");
        ItemsName.Add(Item.Type.mens_shoe3, "Mens Shoe No.3");
        ItemsName.Add(Item.Type.mens_shoe2, "Mens Shoe No.2");
        ItemsName.Add(Item.Type.mens_shoe1, "Mens Shoe No.1");
        ItemsName.Add(Item.Type.lady_shoe16, "Lady Shoe No.16");
        ItemsName.Add(Item.Type.lady_shoe15, "Lady Shoe No.15");
        ItemsName.Add(Item.Type.lady_shoe14, "Lady Shoe No.14");
        ItemsName.Add(Item.Type.lady_shoe13, "Lady Shoe No.13");
        ItemsName.Add(Item.Type.lady_shoe12, "Lady Shoe No.12");
        ItemsName.Add(Item.Type.lady_shoe11, "Lady Shoe No.11");
        ItemsName.Add(Item.Type.lady_shoe10, "Lady Shoe No.10");
        ItemsName.Add(Item.Type.lady_shoe9, "Lady Shoe No.9");
        ItemsName.Add(Item.Type.lady_shoe8, "Lady Shoe No.8");
        ItemsName.Add(Item.Type.lady_shoe7, "Lady Shoe No.7");
        ItemsName.Add(Item.Type.lady_shoe6, "Lady Shoe No.6");
        ItemsName.Add(Item.Type.lady_shoe5, "Lady Shoe No.5");
        ItemsName.Add(Item.Type.lady_shoe4, "Lady Shoe No.4");
        ItemsName.Add(Item.Type.lady_shoe3, "Lady Shoe No.3");
        ItemsName.Add(Item.Type.lady_shoe2, "Lady Shoe No.2");
        ItemsName.Add(Item.Type.lady_shoe1, "Lady Shoe No.1");
        //store6 clothing assign sprite
        ItemsImage.Add(Item.Type.hanging_tshirt_unity_white, Resources.Load<Sprite>("6_hangtshirtunitywhite"));
        ItemsImage.Add(Item.Type.tshirt_unity_yellow, Resources.Load<Sprite>("6_tshirtunityyellow"));
        ItemsImage.Add(Item.Type.tshirt_studio_black, Resources.Load<Sprite>("6_tshirtstudioblack"));
        ItemsImage.Add(Item.Type.hanging_tshirt_unity_red, Resources.Load<Sprite>("6_hangingtshirtunityred"));
        ItemsImage.Add(Item.Type.hanging_tshirt_unity_green, Resources.Load<Sprite>("6_hangtshirtunitygreen"));
        ItemsImage.Add(Item.Type.hanging_tshirt_unity_blue, Resources.Load<Sprite>("6_hangtshirtunityblue"));
        ItemsImage.Add(Item.Type.hanging_tshirt_unity_black, Resources.Load<Sprite>("6_hangtshirtunityblack"));
        ItemsImage.Add(Item.Type.folded_tshirt_yellow, Resources.Load<Sprite>("6_foldedtshirtyellow"));
        ItemsImage.Add(Item.Type.folded_tshirt_white, Resources.Load<Sprite>("6_foldedtshirtwhite"));
        ItemsImage.Add(Item.Type.folded_tshirt_black, Resources.Load<Sprite>("6_foldedtshirtblack"));
        ItemsImage.Add(Item.Type.folded_tshirt_studio, Resources.Load<Sprite>("6_foldedtshirtstudio"));
        ItemsImage.Add(Item.Type.folded_tshirt_red, Resources.Load<Sprite>("6_foldedtshirtred"));
        ItemsImage.Add(Item.Type.folded_tshirt_pink, Resources.Load<Sprite>("6_foldedtshirtpink"));
        ItemsImage.Add(Item.Type.folded_tshirt_blue, Resources.Load<Sprite>("6_foldedtshirtblue"));
        ItemsImage.Add(Item.Type.trainers_white, Resources.Load<Sprite>("6_trainerswhite"));
        ItemsImage.Add(Item.Type.trainers_green, Resources.Load<Sprite>("6_trainersgreen"));
        ItemsImage.Add(Item.Type.trainers_blue, Resources.Load<Sprite>("6_trainersblue"));
        ItemsImage.Add(Item.Type.trainers_black, Resources.Load<Sprite>("6_trainersblack"));
        ItemsImage.Add(Item.Type.jeans_black, Resources.Load<Sprite>("6_jeansblack"));
        ItemsImage.Add(Item.Type.jacket, Resources.Load<Sprite>("6_jacket"));
        ItemsImage.Add(Item.Type.hat_yellow, Resources.Load<Sprite>("6_hatyellow"));
        ItemsImage.Add(Item.Type.hat_white, Resources.Load<Sprite>("6_hatwhite"));
        ItemsImage.Add(Item.Type.hat_brown, Resources.Load<Sprite>("6_hatbrown"));
        ItemsImage.Add(Item.Type.hat_blue, Resources.Load<Sprite>("6_hatblue"));
        ItemsImage.Add(Item.Type.hat_black, Resources.Load<Sprite>("6_hatblack"));
        ItemsImage.Add(Item.Type.mens_shoe8, Resources.Load<Sprite>("6_mensshoe8"));
        ItemsImage.Add(Item.Type.mens_shoe7, Resources.Load<Sprite>("6_mensshoe7"));
        ItemsImage.Add(Item.Type.mens_shoe6, Resources.Load<Sprite>("6_mensshoe6"));
        ItemsImage.Add(Item.Type.mens_shoe5, Resources.Load<Sprite>("6_mensshoe5"));
        ItemsImage.Add(Item.Type.mens_shoe4, Resources.Load<Sprite>("6_mensshoe4"));
        ItemsImage.Add(Item.Type.mens_shoe3, Resources.Load<Sprite>("6_mensshoe3"));
        ItemsImage.Add(Item.Type.mens_shoe2, Resources.Load<Sprite>("6_mensshoe2"));
        ItemsImage.Add(Item.Type.mens_shoe1, Resources.Load<Sprite>("6_mensshoe1"));
        ItemsImage.Add(Item.Type.lady_shoe16, Resources.Load<Sprite>("6_ladyshoe16"));
        ItemsImage.Add(Item.Type.lady_shoe15, Resources.Load<Sprite>("6_ladyshoe15"));
        ItemsImage.Add(Item.Type.lady_shoe14, Resources.Load<Sprite>("6_ladyshoe14"));
        ItemsImage.Add(Item.Type.lady_shoe13, Resources.Load<Sprite>("6_ladyshoe13"));
        ItemsImage.Add(Item.Type.lady_shoe12, Resources.Load<Sprite>("6_ladyshoe12"));
        ItemsImage.Add(Item.Type.lady_shoe11, Resources.Load<Sprite>("6_ladyshoe11"));
        ItemsImage.Add(Item.Type.lady_shoe10, Resources.Load<Sprite>("6_ladyshoe10"));
        ItemsImage.Add(Item.Type.lady_shoe9, Resources.Load<Sprite>("6_ladyshoe9"));
        ItemsImage.Add(Item.Type.lady_shoe8, Resources.Load<Sprite>("6_ladyshoe8"));
        ItemsImage.Add(Item.Type.lady_shoe7, Resources.Load<Sprite>("6_ladyshoe7"));
        ItemsImage.Add(Item.Type.lady_shoe6, Resources.Load<Sprite>("6_ladyshoe6"));
        ItemsImage.Add(Item.Type.lady_shoe5, Resources.Load<Sprite>("6_ladyshoe5"));
        ItemsImage.Add(Item.Type.lady_shoe4, Resources.Load<Sprite>("6_ladyshoe4"));
        ItemsImage.Add(Item.Type.lady_shoe3, Resources.Load<Sprite>("6_ladyshoe3"));
        ItemsImage.Add(Item.Type.lady_shoe2, Resources.Load<Sprite>("6_ladyshoe2"));
        ItemsImage.Add(Item.Type.lady_shoe1, Resources.Load<Sprite>("6_ladyshoe1"));

        //store7 food assign string
        ItemsName.Add(Item.Type.straberry, "Strawberry");
        //ItemsName.Add(Item.Type.pear, "Pear");
        //ItemsName.Add(Item.Type.kiwi, "Kiwi");
        //ItemsName.Add(Item.Type.banana, "Banana");
        //ItemsName.Add(Item.Type.apple, "Apple");
        ItemsName.Add(Item.Type.tinned_can3, "Tomato Can");
        ItemsName.Add(Item.Type.tinned_can2, "Pea Stew Can");
        ItemsName.Add(Item.Type.tinned_can1, "Ministrone Can");
        ItemsName.Add(Item.Type.tuna, "Tuna Can");
        ItemsName.Add(Item.Type.squid, "Squid Can");
        ItemsName.Add(Item.Type.soup, "Soup Can");
        ItemsName.Add(Item.Type.milkbox, "Milk (Box)");
        ItemsName.Add(Item.Type.jar, "Jar");
        ItemsName.Add(Item.Type.corn, "Corn Can");
        ItemsName.Add(Item.Type.chips, "Chips Bag");
        ItemsName.Add(Item.Type.cornbox, "Cornbox");
        ItemsName.Add(Item.Type.watermelon, "Watermelon");
        ItemsName.Add(Item.Type.sauce1, "Souce");
        ItemsName.Add(Item.Type.rollingpin, "Rolling Pin");
        ItemsName.Add(Item.Type.milkbottle, "Milk (Bottle)");
        ItemsName.Add(Item.Type.lemon, "Lemon");
        ItemsName.Add(Item.Type.deeppan, "Deep Pan");
        ItemsName.Add(Item.Type.cornflakes, "Corn Flakes");
        ItemsName.Add(Item.Type.board, "Food Board");
        ItemsName.Add(Item.Type.apple_big, "Apple Big");
        ItemsName.Add(Item.Type.can4, "Soda Can Red");
        ItemsName.Add(Item.Type.can3, "Soda Can Purple");
        ItemsName.Add(Item.Type.can2, "Soda Can Orange");
        ItemsName.Add(Item.Type.can1, "Soda Can Green");
        ItemsName.Add(Item.Type.can, "Soda Can Blue");
        ItemsName.Add(Item.Type.bottle4, "Soda Bottle Red");
        ItemsName.Add(Item.Type.bottle3, "Soda Bottle Purple");
        ItemsName.Add(Item.Type.bottle2, "Soda Bottle Orange");
        ItemsName.Add(Item.Type.bottle1, "Soda Bottle Green");
        ItemsName.Add(Item.Type.bottle, "Soda Bottle Blue");
        ItemsName.Add(Item.Type.croissant_03_mid, "Croissant 1");
        ItemsName.Add(Item.Type.croissant_03_low, "Croissant 2");
        ItemsName.Add(Item.Type.croissant_02_mid, "Croissant 3");
        ItemsName.Add(Item.Type.croissant_02_low, "Croissant 4");
        ItemsName.Add(Item.Type.croissant_01_mid, "Croissant 5");
        ItemsName.Add(Item.Type.croissant_01_low, "Croissant 6");
        //store7 food assign sprite
        ItemsImage.Add(Item.Type.straberry, Resources.Load<Sprite>("7_straberry"));
        ItemsImage.Add(Item.Type.pear, Resources.Load<Sprite>("7_pear"));
        ItemsImage.Add(Item.Type.kiwi, Resources.Load<Sprite>("7_kiwi"));
        ItemsImage.Add(Item.Type.banana, Resources.Load<Sprite>("7_banana"));
        ItemsImage.Add(Item.Type.apple, Resources.Load<Sprite>("7_apple"));
        ItemsImage.Add(Item.Type.tinned_can3, Resources.Load<Sprite>("7_tinnedcan3"));
        ItemsImage.Add(Item.Type.tinned_can2, Resources.Load<Sprite>("7_tinnedcan2"));
        ItemsImage.Add(Item.Type.tinned_can1, Resources.Load<Sprite>("7_tinnedcan1"));
        ItemsImage.Add(Item.Type.tuna, Resources.Load<Sprite>("7_tuna"));
        ItemsImage.Add(Item.Type.squid, Resources.Load<Sprite>("7_squid"));
        ItemsImage.Add(Item.Type.soup, Resources.Load<Sprite>("7_soup"));
        ItemsImage.Add(Item.Type.milkbox, Resources.Load<Sprite>("7_milkbox"));
        ItemsImage.Add(Item.Type.jar, Resources.Load<Sprite>("7_jar"));
        ItemsImage.Add(Item.Type.corn, Resources.Load<Sprite>("7_corn"));
        ItemsImage.Add(Item.Type.chips, Resources.Load<Sprite>("7_chips"));
        ItemsImage.Add(Item.Type.cornbox, Resources.Load<Sprite>("7_cornbox"));
        ItemsImage.Add(Item.Type.watermelon, Resources.Load<Sprite>("7_watermelon"));
        ItemsImage.Add(Item.Type.sauce1, Resources.Load<Sprite>("7_sauce1"));
        ItemsImage.Add(Item.Type.rollingpin, Resources.Load<Sprite>("7_rollingpin"));
        ItemsImage.Add(Item.Type.milkbottle, Resources.Load<Sprite>("7_milkbottle"));
        ItemsImage.Add(Item.Type.lemon, Resources.Load<Sprite>("7_lemon"));
        ItemsImage.Add(Item.Type.deeppan, Resources.Load<Sprite>("7_deeppan"));
        ItemsImage.Add(Item.Type.cornflakes, Resources.Load<Sprite>("7_cornflakes"));
        ItemsImage.Add(Item.Type.board, Resources.Load<Sprite>("7_board"));
        ItemsImage.Add(Item.Type.apple_big, Resources.Load<Sprite>("7_applebig"));
        ItemsImage.Add(Item.Type.can4, Resources.Load<Sprite>("7_can4"));
        ItemsImage.Add(Item.Type.can3, Resources.Load<Sprite>("7_can3"));
        ItemsImage.Add(Item.Type.can2, Resources.Load<Sprite>("7_can2"));
        ItemsImage.Add(Item.Type.can1, Resources.Load<Sprite>("7_can1"));
        ItemsImage.Add(Item.Type.can, Resources.Load<Sprite>("7_can"));
        ItemsImage.Add(Item.Type.bottle4, Resources.Load<Sprite>("7_bottle4"));
        ItemsImage.Add(Item.Type.bottle3, Resources.Load<Sprite>("7_bottle3"));
        ItemsImage.Add(Item.Type.bottle2, Resources.Load<Sprite>("7_bottle2"));
        ItemsImage.Add(Item.Type.bottle1, Resources.Load<Sprite>("7_bottle1"));
        ItemsImage.Add(Item.Type.bottle, Resources.Load<Sprite>("7_bottle"));
        ItemsImage.Add(Item.Type.croissant_03_mid, Resources.Load<Sprite>("7_croissant03mid"));
        ItemsImage.Add(Item.Type.croissant_03_low, Resources.Load<Sprite>("7_croissant03low"));
        ItemsImage.Add(Item.Type.croissant_02_mid, Resources.Load<Sprite>("7_croissant02mid"));
        ItemsImage.Add(Item.Type.croissant_02_low, Resources.Load<Sprite>("7_croissant02low"));
        ItemsImage.Add(Item.Type.croissant_01_mid, Resources.Load<Sprite>("7_croissant01mid"));
        ItemsImage.Add(Item.Type.croissant_01_low, Resources.Load<Sprite>("7_croissant01low"));

        //store8 toys assign string
        ItemsName.Add(Item.Type.tricycle, "Tricycle");
        ItemsName.Add(Item.Type.traincart2, "Train Cart 2");
        ItemsName.Add(Item.Type.traincart1, "Train Cart 1");
        ItemsName.Add(Item.Type.train, "Train 1");
        ItemsName.Add(Item.Type.rocket, "Rocket");
        ItemsName.Add(Item.Type.mouse, "Mouse");
        ItemsName.Add(Item.Type.horse, "Horse");
        ItemsName.Add(Item.Type.duck, "Duck");
        ItemsName.Add(Item.Type.car, "Car");
        ItemsName.Add(Item.Type.ball, "Ball");
        ItemsName.Add(Item.Type.airplane, "Airplane");
        ItemsName.Add(Item.Type.xylophone2, "xylophone 2");
        ItemsName.Add(Item.Type.xylophone1, "xylophone 1");
        ItemsName.Add(Item.Type.rhythmegg_yellow, "Rhythm Egg Yellow");
        ItemsName.Add(Item.Type.rhythmegg_blue, "Rhythm Egg Blue");
        ItemsName.Add(Item.Type.rhythmegg_red, "Rhythm Egg Red");
        ItemsName.Add(Item.Type.rhythmegg_green, "Rhythm Egg Green");
        ItemsName.Add(Item.Type.rhythmegg_gold, "Rhythm Egg Gold");
        ItemsName.Add(Item.Type.piano_wood, "Piano Wood");
        ItemsName.Add(Item.Type.piano_white, "Piano White");
        ItemsName.Add(Item.Type.piano_yellow, "Piano Yellow");
        ItemsName.Add(Item.Type.piano_green, "Piano Green");
        ItemsName.Add(Item.Type.piano_pink, "Piano Pink");
        ItemsName.Add(Item.Type.piano_blue, "Piano Blue");
        ItemsName.Add(Item.Type.piano_black, "Piano Black");
        ItemsName.Add(Item.Type.maracas6, "Maracas 6");
        ItemsName.Add(Item.Type.maracas5, "Maracas 5");
        ItemsName.Add(Item.Type.maracas4, "Maracas 4");
        ItemsName.Add(Item.Type.maracas3, "Maracas 3");
        ItemsName.Add(Item.Type.maracas2, "Maracas 2");
        ItemsName.Add(Item.Type.maracas1, "Maracas 1");
        ItemsName.Add(Item.Type.harmonica7, "Harmonica 7");
        ItemsName.Add(Item.Type.harmonica6, "Harmonica 6");
        ItemsName.Add(Item.Type.harmonica5, "Harmonica 5");
        ItemsName.Add(Item.Type.harmonica4, "Harmonica 4");
        ItemsName.Add(Item.Type.harmonica3, "Harmonica 3");
        ItemsName.Add(Item.Type.harmonica2, "Harmonica 2");
        ItemsName.Add(Item.Type.harmonica1, "Harmonica 1");
        ItemsName.Add(Item.Type.flute_yellow, "Flute Yellow");
        ItemsName.Add(Item.Type.flute_red, "Flute Red");
        ItemsName.Add(Item.Type.flute_green, "Flute Green");
        ItemsName.Add(Item.Type.flute_blue, "Flute Blue");
        ItemsName.Add(Item.Type.flute_white, "Flute White");
        ItemsName.Add(Item.Type.flute_orange, "Flute Orange");
        ItemsName.Add(Item.Type.flute_pink, "Flute Pink");
        ItemsName.Add(Item.Type.flute_brown, "Flute Brown");
        ItemsName.Add(Item.Type.drumandstick6, "Drum 6");
        ItemsName.Add(Item.Type.drumandstick5, "Drum 5");
        ItemsName.Add(Item.Type.drumandstick4, "Drum 4");
        ItemsName.Add(Item.Type.drumandstick3, "Drum 3");
        ItemsName.Add(Item.Type.drumandstick2, "Drum 2");
        ItemsName.Add(Item.Type.drumandstick1, "Drum 1");
        ItemsName.Add(Item.Type.toysnowman, "Snowman");
        ItemsName.Add(Item.Type.toybell, "Toy Bell");
        ItemsName.Add(Item.Type.toyball, "Toy Ball");
        ItemsName.Add(Item.Type.GiftBox_Square_TypeB, "Gift Box 1");
        ItemsName.Add(Item.Type.GiftBox_Square_TypeA, "Gift Box 2");
        ItemsName.Add(Item.Type.GiftBox_Rectangle_TypeB, "Gift Box 3");
        ItemsName.Add(Item.Type.GiftBox_Rectangle_TypeA, "Gift Box 4");
        ItemsName.Add(Item.Type.GiftBox_Cylinder_TypeB, "Gift Box 5");
        ItemsName.Add(Item.Type.GiftBox_Cylinder_TypeA, "Gift Box 6");
        ItemsName.Add(Item.Type.ChristmasSock, "Christmas Sock");
        ItemsName.Add(Item.Type.CandyCaneWithBow, "Candy 1");
        ItemsName.Add(Item.Type.Candy, "Candy 2");
        ItemsName.Add(Item.Type.Candle_Small, "Candle");
        ItemsName.Add(Item.Type.BabyStroller05, "Baby Stroller 5");
        ItemsName.Add(Item.Type.BabyStroller04, "Baby Stroller 4");
        ItemsName.Add(Item.Type.BabyStroller03, "Baby Stroller 3");
        ItemsName.Add(Item.Type.BabyStroller02, "Baby Stroller 2");
        ItemsName.Add(Item.Type.BabyStroller01, "Baby Stroller 1");
        ItemsName.Add(Item.Type.Train_toy, "Train 2");
        ItemsName.Add(Item.Type.Tank_toy, "Tank");
        ItemsName.Add(Item.Type.Ship_toy, "Ship");
        ItemsName.Add(Item.Type.Helicopter_toy, "Helicopter");
        ItemsName.Add(Item.Type.Duck_toy, "Duck");
        //store8 toys assign sprite
        ItemsImage.Add(Item.Type.tricycle, Resources.Load<Sprite>("8_trucycle"));
        ItemsImage.Add(Item.Type.traincart2, Resources.Load<Sprite>("8_traincart2"));
        ItemsImage.Add(Item.Type.traincart1, Resources.Load<Sprite>("8_traincart1"));
        ItemsImage.Add(Item.Type.train, Resources.Load<Sprite>("8_train"));
        ItemsImage.Add(Item.Type.rocket, Resources.Load<Sprite>("8_rocket"));
        ItemsImage.Add(Item.Type.mouse, Resources.Load<Sprite>("8_mouse"));
        ItemsImage.Add(Item.Type.horse, Resources.Load<Sprite>("8_horse"));
        ItemsImage.Add(Item.Type.duck, Resources.Load<Sprite>("8_duck"));
        ItemsImage.Add(Item.Type.car, Resources.Load<Sprite>("8_car"));
        ItemsImage.Add(Item.Type.ball, Resources.Load<Sprite>("8_ball"));
        ItemsImage.Add(Item.Type.airplane, Resources.Load<Sprite>("8_airplane"));
        ItemsImage.Add(Item.Type.xylophone2, Resources.Load<Sprite>("8_xylophone2"));
        ItemsImage.Add(Item.Type.xylophone1, Resources.Load<Sprite>("8_xylophone1"));
        ItemsImage.Add(Item.Type.rhythmegg_yellow, Resources.Load<Sprite>("8_rhythmeggyellow"));
        ItemsImage.Add(Item.Type.rhythmegg_blue, Resources.Load<Sprite>("8_rhythmeggblue"));
        ItemsImage.Add(Item.Type.rhythmegg_red, Resources.Load<Sprite>("8_rhythmeggred"));
        ItemsImage.Add(Item.Type.rhythmegg_green, Resources.Load<Sprite>("8_rhythmegggreen"));
        ItemsImage.Add(Item.Type.rhythmegg_gold, Resources.Load<Sprite>("8_rhythmegggold"));
        ItemsImage.Add(Item.Type.piano_wood, Resources.Load<Sprite>("8_pianowood"));
        ItemsImage.Add(Item.Type.piano_white, Resources.Load<Sprite>("8_pianowhite"));
        ItemsImage.Add(Item.Type.piano_yellow, Resources.Load<Sprite>("8_pianoyellow"));
        ItemsImage.Add(Item.Type.piano_green, Resources.Load<Sprite>("8_pianogreen"));
        ItemsImage.Add(Item.Type.piano_pink, Resources.Load<Sprite>("8_pianopink"));
        ItemsImage.Add(Item.Type.piano_blue, Resources.Load<Sprite>("8_pianoblue"));
        ItemsImage.Add(Item.Type.piano_black, Resources.Load<Sprite>("8_pianobalck"));
        ItemsImage.Add(Item.Type.maracas6, Resources.Load<Sprite>("8_maracas6"));
        ItemsImage.Add(Item.Type.maracas5, Resources.Load<Sprite>("8_maracas5"));
        ItemsImage.Add(Item.Type.maracas4, Resources.Load<Sprite>("8_maracas4"));
        ItemsImage.Add(Item.Type.maracas3, Resources.Load<Sprite>("8_maracas3"));
        ItemsImage.Add(Item.Type.maracas2, Resources.Load<Sprite>("8_maracas2"));
        ItemsImage.Add(Item.Type.maracas1, Resources.Load<Sprite>("8_maracas1"));
        ItemsImage.Add(Item.Type.harmonica7, Resources.Load<Sprite>("8_harmonica7"));
        ItemsImage.Add(Item.Type.harmonica6, Resources.Load<Sprite>("8_harmonica6"));
        ItemsImage.Add(Item.Type.harmonica5, Resources.Load<Sprite>("8_harmonica5"));
        ItemsImage.Add(Item.Type.harmonica4, Resources.Load<Sprite>("8_harmonica4"));
        ItemsImage.Add(Item.Type.harmonica3, Resources.Load<Sprite>("8_harmonica3"));
        ItemsImage.Add(Item.Type.harmonica2, Resources.Load<Sprite>("8_harmonica2"));
        ItemsImage.Add(Item.Type.harmonica1, Resources.Load<Sprite>("8_harmonica1"));
        ItemsImage.Add(Item.Type.flute_yellow, Resources.Load<Sprite>("8_fluteyellow"));
        ItemsImage.Add(Item.Type.flute_red, Resources.Load<Sprite>("8_flutered"));
        ItemsImage.Add(Item.Type.flute_green, Resources.Load<Sprite>("8_flutegreen"));
        ItemsImage.Add(Item.Type.flute_blue, Resources.Load<Sprite>("8_fluteblue"));
        ItemsImage.Add(Item.Type.flute_white, Resources.Load<Sprite>("8_flutewhite"));
        ItemsImage.Add(Item.Type.flute_orange, Resources.Load<Sprite>("8_fluteorange"));
        ItemsImage.Add(Item.Type.flute_pink, Resources.Load<Sprite>("8_flutepink"));
        ItemsImage.Add(Item.Type.flute_brown, Resources.Load<Sprite>("8_flutebrown"));
        ItemsImage.Add(Item.Type.drumandstick6, Resources.Load<Sprite>("8_drumandstick6"));
        ItemsImage.Add(Item.Type.drumandstick5, Resources.Load<Sprite>("8_drumandstick5"));
        ItemsImage.Add(Item.Type.drumandstick4, Resources.Load<Sprite>("8_drumandstick4"));
        ItemsImage.Add(Item.Type.drumandstick3, Resources.Load<Sprite>("8_drumandstick3"));
        ItemsImage.Add(Item.Type.drumandstick2, Resources.Load<Sprite>("8_drumandstick2"));
        ItemsImage.Add(Item.Type.drumandstick1, Resources.Load<Sprite>("8_drumandstick1"));
        ItemsImage.Add(Item.Type.toysnowman, Resources.Load<Sprite>("8_toysnowman"));
        ItemsImage.Add(Item.Type.toybell, Resources.Load<Sprite>("8_toybell"));
        ItemsImage.Add(Item.Type.toyball, Resources.Load<Sprite>("8_toyball"));
        ItemsImage.Add(Item.Type.GiftBox_Square_TypeB, Resources.Load<Sprite>("8_giftboxsquaretypeb"));
        ItemsImage.Add(Item.Type.GiftBox_Square_TypeA, Resources.Load<Sprite>("8_giftboxsquaretypea"));
        ItemsImage.Add(Item.Type.GiftBox_Rectangle_TypeB, Resources.Load<Sprite>("8_giftboxrectangletypeb"));
        ItemsImage.Add(Item.Type.GiftBox_Rectangle_TypeA, Resources.Load<Sprite>("8_giftboxrectangletypea"));
        ItemsImage.Add(Item.Type.GiftBox_Cylinder_TypeB, Resources.Load<Sprite>("8_giftboxcylindertypeb"));
        ItemsImage.Add(Item.Type.GiftBox_Cylinder_TypeA, Resources.Load<Sprite>("8_giftboxcylindertypea"));
        ItemsImage.Add(Item.Type.ChristmasSock, Resources.Load<Sprite>("8_christmassock"));
        ItemsImage.Add(Item.Type.CandyCaneWithBow, Resources.Load<Sprite>("8_cnadycanewithbow"));
        ItemsImage.Add(Item.Type.Candy, Resources.Load<Sprite>("8_candy"));
        ItemsImage.Add(Item.Type.Candle_Small, Resources.Load<Sprite>("8_candlesmall"));
        ItemsImage.Add(Item.Type.BabyStroller05, Resources.Load<Sprite>("8_babystroller05"));
        ItemsImage.Add(Item.Type.BabyStroller04, Resources.Load<Sprite>("8_babystroller04"));
        ItemsImage.Add(Item.Type.BabyStroller03, Resources.Load<Sprite>("8_babystroller03"));
        ItemsImage.Add(Item.Type.BabyStroller02, Resources.Load<Sprite>("8_babystroller02"));
        ItemsImage.Add(Item.Type.BabyStroller01, Resources.Load<Sprite>("8_babystroller01"));
        ItemsImage.Add(Item.Type.Train_toy, Resources.Load<Sprite>("8_traintoy"));
        ItemsImage.Add(Item.Type.Tank_toy, Resources.Load<Sprite>("8_tanktoy"));
        ItemsImage.Add(Item.Type.Ship_toy, Resources.Load<Sprite>("8_shiptoy"));
        ItemsImage.Add(Item.Type.Helicopter_toy, Resources.Load<Sprite>("8_helicoptertoy"));
        ItemsImage.Add(Item.Type.Duck_toy, Resources.Load<Sprite>("8_ducktoy"));
    }

    void Update()
    {
        float price = 0;

        foreach (GameObject entry in ShoppingCart.Instance.BoughtItems)
            price += entry.GetComponent<Item>().price;

        foreach (GameObject entry in ShoppingCart1.Instance.BoughtItems)
            price += entry.GetComponent<Item>().price;

        foreach (GameObject entry in ShoppingCart2.Instance.BoughtItems)
            price += entry.GetComponent<Item>().price;

        foreach (GameObject entry in ShoppingCart3.Instance.BoughtItems)
            price += entry.GetComponent<Item>().price;

        foreach (GameObject entry in ShoppingCart4.Instance.BoughtItems)
            price += entry.GetComponent<Item>().price;

        foreach (GameObject entry in ShoppingCart5.Instance.BoughtItems)
            price += entry.GetComponent<Item>().price;

        foreach (GameObject entry in ShoppingCart6.Instance.BoughtItems)
            price += entry.GetComponent<Item>().price;

        foreach (GameObject entry in ShoppingCart7.Instance.BoughtItems)
            price += entry.GetComponent<Item>().price;

        foreach (GameObject entry in ShoppingCart8.Instance.BoughtItems)
            price += entry.GetComponent<Item>().price;

        transform.Find("TotalPrice").GetComponent<Text>().text = "Total $   " + price.ToString("0");
        // update total price
    }

    public void AddItem(Item item)
    {
        Debug.Log("COP00 ADD");
        if (ItemBlocks.ContainsKey(item.ItemType))
        {
            //amount ++
            int amount = int.Parse(ItemBlocks[item.ItemType].transform.Find("Amount").GetComponent<Text>().text);
            amount++;
            print(amount);
            ItemBlocks[item.ItemType].transform.Find("Amount").GetComponent<Text>().text = amount.ToString();
        }
        else
        {

            GameObject block = Instantiate(ItemBlock, transform.Find("ItemBlocks")) as GameObject;
            block.transform.localScale = Vector3.one;
            block.transform.localRotation = Quaternion.identity;
            block.transform.localPosition = new Vector3(block.transform.localPosition.x, block.transform.localPosition.y, 0);

            block.transform.Find("Image").GetComponent<Image>().sprite = ItemsImage[item.ItemType];
            block.transform.Find("ItemName").GetComponent<Text>().text = ItemsName[item.ItemType];
            //            block.transform.Find("ItemName").GetComponent<Text>().resizeTextMinSize = 14;
            block.transform.Find("Subtitle").GetComponent<Text>().text = "";
            block.transform.Find("Amount").GetComponent<Text>().text = 1.ToString();
            block.transform.Find("Price").GetComponent<Text>().text = "$ " + item.price.ToString();

            ItemBlocks.Add(item.ItemType, block);
            //instantiate item block

        }
    }

    public void RemoveItem(Item item)
    {
        if (ItemBlocks.ContainsKey(item.ItemType))
        {
            int amount = int.Parse(ItemBlocks[item.ItemType].transform.Find("Amount").GetComponent<Text>().text);

            if (amount == 1)
            {
                Destroy(ItemBlocks[item.ItemType]);
                ItemBlocks.Remove(item.ItemType);
            }
            else
            {
                amount--;
                ItemBlocks[item.ItemType].transform.Find("Amount").GetComponent<Text>().text = amount.ToString();
            }
        }
        else
        {
            Debug.LogError("ERROR!!");
        }
    }

    /*    public void onClick()
        {
            // Close game
            Debug.Log("Application Closing");
            Application.Quit();
        }
    */

}
