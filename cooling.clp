

(defmodule G (export ?ALL))

(deffunction G::CoolingWork ;How the Cooling System Works
()

(printout cool " "crlf
            "Combustion engines generate a lot of heat, and to prevent the metal components from overheating, fuel-burning cars need a way to transfer the heat from the engine to the outside air."crlf
            "This is the job of the cooling system."crlf
            " "crlf
            "  Most cars have a liquid cooling system, which uses a liquid coolant that runs through the engine and is then pumped into a radiator to transfer the heat to the air."crlf
            "  Car engines run at nearly the same temperature that water boils (212°F or 100°C), so they must use a combination of coolant and water to allow the coolant to run hotter than straight water."crlf
            "  In cold temperatures, the same liquid acts as an antifreeze, preventing the water from freezing and expanding, which can crack metal parts."crlf
            "  "crlf
            "Common components of a liquid cooling system:"crlf
            " "crlf
            "Radiator:"crlf
            " "crlf
            "The radiator is usually mounted on the front of the car."crlf
            "Coolant from the engine is pumped through it and the heat from the coolant is transferred from the tubes to the small fins lining the tubes."crlf
            "As air flows over the fins, the heat is transferred to the surrounding air."crlf
            "The engine then pumps the cooled coolant from the bottom of the radiator back into the engine to pick up more heat."crlf
            " "crlf
            "Water Pump:"crlf
            " "crlf
            "The water pump takes cooled liquid from the bottom of the radiator and pushes it through the engine and then back to the radiator."crlf
            "The water pump may be driven by a belt from the engine, or electrically from the alternator."crlf
            " "crlf
            "Thermostat:"crlf
            " "crlf
            "The thermostat regulates the engine temperature."crlf
            "Since metal expands when it heats, the engine is designed to run best at a heated temperature."crlf
            "If the engine takes too long to come up to temperature it can cause problems."crlf
            "The thermostat senses when the temperature has reached an optimum point and then opens up,allowing the coolant to run through the radiator."crlf
            " "crlf
            "Cooling Fan:"crlf
            " "crlf
            "A cooling fan is used when the car is not moving fast enough to allow air to flow over the radiator."crlf
            "Cooling fans are mostly electric, but they can be powered by an engine belt."crlf
            "Mechanical fans sometimes use a clutch to allow them to spin freely when the car is moving fast enough, saving energy."crlf
            "Electric fans can be turned on and off by temperature sensors or by the computer."crlf
            " "crlf
            "Heater Core:"crlf
            " "crlf
            "The waste heat from the engine is used to heat the inside of the car when needed."crlf
            "It does this using a heater core."crlf
            "The heater core looks like a small radiator, and it works just like the radiator by transferring heat to the surrounding air."crlf
            "It is usually mounted in a box under the dash alongside with the air conditioner evaporator."crlf
            " "crlf
            "Hoses:"crlf
            " "crlf
            "Most engines use a combination of hoses and tubes to transfer the heat from the engine to the radiator and the heater core."crlf
            "The flexible hoses allow the engine to move during operation and are usually held in place with clamps."crlf
            " "crlf
            "Overflow Tank:"crlf
            " "crlf
            "An overflow tank, also called a de-gas tank or coolant reservoir, is used as a reservoir for extra coolant."crlf
            "As the engine heats up and cools down, this tank holds the extra coolant,ready to be delivered by the water pump."crlf
            "It also provides a safe way to check the coolant level and add more coolant, if needed."crlf
            " "crlf
            "Coolant:"crlf
            " "crlf
            "The coolant, or antifreeze, is the liquid component of the liquid cooling system."crlf
            "It takes heat out of the engine and prevents the cooling system from freezing in low,temperatures."crlf
            "Antifreeze is designed to be mixed with water, so DON'T run straight antifreeze in your car."crlf
            "It is also HIGHLY TOXIC, but has a “sweet” smell that makes it attractive to dogs and other animals."crlf
            "Keep it away from pets and children."crlf
            " "crlf
)
)

(deffunction G::CoolingProblem;Common Cooling System Problems
()

(printout cool " "crlf
            "LEAKS:"crlf
            " "crlf
            "There are a lot of flexible connections in the cooling system and this is where leaks most commonly start."crlf
            "The rubber hoses will begin to wear out and the joints will loosen from movement."crlf
            "A leak can happen anywhere in the system:"crlf
            "The water pump can leak, the radiator can rust through, or the cylinder block can lose a gasket."crlf
            "Leaks in hoses can usually be repaired easily, but leaks in big components like radiators and water pumps generally require the attention of a professional."crlf
            "Leaks that aren’t addressed can lead to overheating, which leads to engine failure."crlf
            "Get a leak repaired RIGHT AWAY!"crlf
            " "crlf
            "RADIATOR FAILURE:"crlf
            " "crlf
            "The coolant in the radiator is mixed with water, and the water can bring with it minerals and deposits that will clog and corrode your radiator."crlf
            "When this happens, the coolant can’t pass through the tubes of the radiator and the engine overheats."crlf
            "If it rusts out, it will eventually drain down and cause overheating."crlf
            " "crlf
            "A mildly corroded radiator can be flushed with commercially available products, or some pros offer a power flush that really gets the radiator clean."crlf
            "You can flush your own radiator, but a severely corroded radiator should be replaced."crlf
            " "crlf
            "WATER PUMP FAILURE:"crlf
            " "crlf
            "The water pump is subject to failure in several ways."crlf
            "A mechanical pump that is mounted to the engine may fail at the gasket points where it connects to the engine, or it may stop working if the engine belt driving it slips or breaks."crlf
            "An electric pump may fail if its internal motor dies."crlf
            "The bearing in the water pump can also give out."crlf
            "A whining sound may indicate that a water pump is about to fail."crlf
            " "crlf
            "THERMOSTAT FAILURE:"crlf
            " "crlf
            "The thermostat is responsible for regulating the flow of coolant by measuring the engine temperature and opening if the engine needs to be cooled down."crlf
            "If the thermostat fails while closed or partially closed, the car will overheat because the coolant can’t flow."crlf
            "If the thermostat fails while open, it will take the engine a much longer time to come up to temperature, which can be hard on the oiling system and cause oil crystallization on the engine components."crlf
            "DON'T run your car without a properly functioning thermostat."crlf
            " "crlf
            "WORN-OUT COOLANT:"crlf
            " "crlf
            "Coolant needs to be topped off or replaced periodically."crlf
            "You can check the level and condition of the coolant in the overflow tank."crlf
            "If the level is low, it can be “topped off ” with distilled water."crlf
            "If it’s getting brown with contaminants or rust, it’s time to change the coolant."crlf
            " "crlf
            "HOSE CLAMP FAILURE:"crlf
            " "crlf
            "Hose clamps usually don’t fail unless they have been removed and reinstalled."crlf
            "Be careful when reinstalling hose clamps that have been stretched,they can fail on reinstallation."crlf
            " "crlf
)
)

(deffunction G::LeakLocation;Locating Leaks
()

(printout cool " "crlf
            "Leaks in the cooling system can be internal or external."crlf
            "Internal leaks, where the coolant is getting into the cylinders and oil pan, can cause serious problems and should be addressed by a professional."crlf
            "External leaks might be easily repaired depending on where they are located."crlf
            " "crlf
            "Here are some ways you can locate a leak in your cooling system:"crlf
            "    Use a piece of cardboard:"crlf
            " "crlf
            "    If you suspect you have a leak but aren’t able to locate the source, place a piece of clean cardboard under the engine area of your car when you park it for the night."crlf
            "    In the morning, the position of the liquid on the cardboard should help you find the leak."crlf
            " "crlf
            "    Inspect the hoses:"crlf
            " "crlf
            "    Rubber components, like the hoses, can often develop leaks since they are designed to flex."crlf
            "    Wearing surgical gloves, gently run your hands around the cold engine and feel for leaks on the back sides of the hoses."crlf
            "    Check the hose connections and make sure the hoses are tightly held in place."crlf
            "    Also check for rusty water or stains on the hoses."crlf
            "    As you go, check your gloves for the fluorescent color of coolant."crlf
            " "crlf
            "   Inspect the radiator:"crlf
            " "crlf
            "   The radiator is made of thin metal fins, which can easily be punctured or rusted."crlf
            "   Corrosion or mineral deposits due to damage could be the sign of a leak."crlf
            " "crlf
            "  Inspect the radiator cap:"crlf
            " "crlf
            "  The rubber seal in the radiator cap can fail, and the metal backing holding the seal can crack and allow pressure to be released."crlf
            "  When the engine is cool, inspect the area around the radiator cap for signs of escaping coolant."crlf
            "  Remove the cap and inspect the underside."crlf
            "  Look for a milky,oily substance—this may be a sign of an internal coolant leak."crlf
            " "crlf
            "  Check the heater core:"crlf
            " "crlf
            "  The heater core is located inside the passenger compartment, and if it starts to leak, it may soak the carpeting with coolant, or it may weep out of the air conditioner drain."crlf
            "  If the inside carpet is getting wet, blot it with a clean rug and look for coolant color or rust."crlf
            " "crlf
            "  Check the thermostat housing:"crlf
            " "crlf
            "  Some thermostats are mounted on the top of the engine where the hot coolant is returned to the radiator, and this is a key area for leaks."crlf
            "  "crlf
            "  Inspect the engine block freeze plugs:"crlf
            " "crlf
            "  The engine is equipped with something called freeze plugs, which pop out if the water in the engine begins to freeze and expand."crlf
            "  These freeze plugs can rust out or weep."crlf
            "  Look for signs of rust trailing down from the freeze plugs."crlf
            " "crlf
            "  Check the head gaskets:"crlf
            " "crlf
            "  There is a gasket between the cylinder block and the cylinder head made of metal."crlf
            "  If it fails, coolant may flood into the cylinders or it may leak out the side of the gasket."crlf
            "  When this happens, you may see a small stream of fluid running down the length of the engine."crlf
            " "crlf
            "  Check the water pump:"crlf
            " "crlf
            "  A water pump failure can happen at the gasket between the pump and engine or at the front bearing on the rotating shaft."crlf
            "  The water pump may have something called a weep hole, which is a hole near the rotating shaft."crlf
            "  This weep hole is used if the water pump is beginning to fail."crlf
            "  If the weep hole is leaking oil, it means the front bearing is failing."crlf
            "  If it is leaking coolant, it means the seals in the pump are failing."crlf
            "  If you see anything coming out of the weep hole, have it checked RIGHT AWAY!"crlf
            " "crlf
            "  Check the oil:"crlf
            " "crlf
            "  Remove the engine oil dipstick and look for a white, milky substance."crlf
            "  This is a sign that there is an internal engine leak and you NEED to have it checked."crlf
            " "crlf
            "  Pressure test the system:"crlf
            " "crlf
            "  Use a radiator pressure tester to test the system."crlf
            "  This is a small pump and gauge that attaches to the radiator in place of the cap."crlf
            "  Bring the cooling system up to pressure and monitor the gauge for a couple of minutes."crlf
            "  If the system doesn’t lose too much pressure, there aren’t any serious leaks."crlf
            "  A quick drop of pressure may confirm an internal leak that you can’t see."crlf
            "  Pressure testers can be expensive, but you may be able to rent one from an auto parts store."crlf
            " "crlf
            "FIXING LEAKS:"crlf
            " "crlf
            "With the exception of tightening or replacing flexible hoses, most cooling system leaks are difficult to repair and should be left to a professional."crlf
            "Temporary fixes are unreliable, and you may make a bad problem worse."crlf
            "Be wary of temporary fixes such as radiator “stop leak” products."crlf
            "These products are made from either a very fine metal powder and binder or a fluid that swells to fill the seals and gaskets."crlf
            "The solution is pumped through the cooling system and it plugs up the small holes."crlf
            "These products can be used for a short-term fix, but they aren’t meant to be a permanent solution."crlf
            "DON'T use these products and consider your problem solved."crlf
            "If you have corrosion, it will continue to get worse."crlf
            "The extra powder floating around in your coolant can clog something else, and if you flush your cooling system,you will probably reopen the leak."crlf
            "The BEST solution is to fix the leak properly."crlf
)
)


(deffunction G::CoolantAddition ;How to: Check and Add Coolant

()

(printout cool " "crlf
            "You should check the level and condition of your coolant on a regular basis, usually at the same time as your oil change."crlf
            "This is especially important if you frequently drive on dirt roads, as it is easy for dust to get into the coolant system and turn into a muddy mess."crlf
            "Rust, mineral deposits, and dirt in the radiator can reduce the ability of the radiator function and may cause major problems."crlf
            " "crlf
            "How to:Check and Add Coolant."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            "  Rug"crlf
            "  Coolant"crlf
            " "crlf
            "1. CHECK COOLANT LEVEL AND CONDITION."crlf
            " "crlf
            "Look for marks on the outside of the reserve tank indicating the proper levels and check that the coolant level is correct."crlf
            "Check the condition of the coolant in the tank by removing the fill cover and inspecting the contents."crlf
            "Look for dirt or mud, rusty coolant, or other contaminants."crlf
            " "crlf
            "2. TOP OFF THE COOLANT IF NEEDED."crlf
            " "crlf
            "If your coolant level is low but in good condition,remove the fill cap and pour in coolant to the proper level."crlf
            " "crlf
            "3. REMOVE THE RADIATOR CAP."crlf
            " "crlf
            "With the engine cold, remove the radiator cap."crlf
            "The cap comes off in two stages."crlf
            "Push down on the cap and rotate it counter-clockwise and it will stop in a middle point."crlf
            "This is a safety point that allows pressure to be released without coolant spraying straight out."crlf
            "Push down again and turn the cap the remainder of the way until you can pull it off."crlf
            "   CAUTION:"crlf
            " "crlf
            "   Coolant systems build pressure when hot, and this pressure can blow scalding hot coolant out and cause severe injury."crlf
            "   NEVER! open a radiator cap while the system is hot."crlf
            " "crlf
            "4. INSPECT THE RADIATOR CAP."crlf
            " "crlf
            "Inspect the underside of the cap for contaminants, rust,or cracking in the rubber seals or metal body."crlf
            "If you see any wear on the cap, it should be replaced."crlf
            "Use a rug to clean off any debris on the seals of the cap."crlf
            " "crlf
            "5. INSPECT THE RADIATOR."crlf
            " "crlf
            "Look down in the radiator and check the condition of the coolant and inside of the radiator."crlf
            "Look for scale buildup on the coolant tubes inside."crlf
            "If you see rust and buildup, you should flush your coolant system, even if it has not reached the manufacturer’s recommended change point."crlf
            "If you see a white, milky, oily substance, you may have a problem in the engine that is causing oil to get into the coolant."crlf
            "If you find a lot of this material, take it to a professional for inspection."crlf
            " "crlf
            "6. REINSTALL THE CAP."crlf
            " "crlf
            "Be sure to push down and twist the cap past the safety point and until it completely stops."crlf
            " "crlf
)
)

(deffunction G::Flush ;How to: Flush and Fill the Cooling System

()

(printout cool " "crlf
            "The fluid in the cooling system needs to be changed regularly, but the frequency differs by manufacturer."crlf
            "Check your owner’s manual and follow your manufacturer’s recommended schedule."crlf
            "Before you fill the cooling system, flushing it by running water through it will help to clear rust, scale, and dirt."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            " "crlf
            "Pan or container to catch the old coolant."crlf
            "Funnel."crlf
            "Clean rugs."crlf
            "Safety gloves and glasses."crlf
            "Garden hose."crlf
            "Pre-mixed coolant, or coolant and distilled water."crlf
            "Flushing additive-optional."crlf
            "Tools to remove the reserve tank-if needed."crlf
            "Jack and jack stands-if needed."crlf
            "Extra liquid containers for recycling-if needed."crlf
            " "crlf
            "1. LOCATE THE RADIATOR DRAIN."crlf
            " "crlf
            "The coolant drain will be at the lowest point of the cooling system, usually in the bottom of the radiator."crlf
            " "crlf
            "2. RAISE CAR IF NEEDED."crlf
            " "crlf
            "Since some cars are very low to the ground, it may be necessary to jack up the front end and place the vehicle on jack stands."crlf
            " "crlf
            "3. DRAIN THE RADIATOR."crlf
            " "crlf
            "With the engine cold, place your pan or container under the drain valve and open the drain, allowing the coolant to exit."crlf
            "Remove the radiator cap to allow air to fill the coolant system."crlf
            "Some cars have air bleed valves located in the system."crlf
            "These should be opened when draining the coolant."crlf
            "Check your shop manual and see if your vehicle is equipped with a bleed valve."crlf
            " "crlf
            "4. FLUSH THE SYSTEM WITH WATER."crlf
            " "crlf
            "The first round of flushing can be done with a garden hose."crlf
            "Place the hose in the radiator cap opening and then turn on the water, letting it flow through the radiator to flush out loose contaminants."crlf
            "The water and dirt will run out the drain valve."crlf
            "Let the radiator flush for a couple of minutes."crlf
            " "crlf
            "5. CLOSE VALVES."crlf
            " "crlf
            "Once you are done, close the drain valve on the radiator and any air bleed valves you may have opened."crlf
            " "crlf
            "6. CLEAN THE RESERVE TANK."crlf
            " "crlf
            "If you’re able to easily remove the reserve tank, clean it out to remove the slime and buildup."crlf
            "If you cannot easily remove the tank, you can flush the tank by carefully removing the hose that attaches it to the radiator and flushing it with water."crlf
            " "crlf
            "7. ADD FLUSHING ADDITIVE AND WATER-OPTIONAL."crlf
            " "crlf
            "If you are not using a flushing additive, proceed to step 9."crlf
            "If you are using a flushing additive, add it to the radiator."crlf
            "Then fill the cooling system with water."crlf
            "When it reaches the top, stop filling and wait a few seconds to allow the system to “burp” air out of the lines."crlf
            "You may need to top off the water several times while the system releases air."crlf
            " "crlf
            "8. CLOSE THE RADIATOR CAP AND RUN THE VEHICLE."crlf
            " "crlf
            "Turn the heater on to make sure the water is flowing through the heater core."crlf
            "Allow the vehicle to come up to temperature, and let it run for about 10 minutes to allow the flush to work through the system."crlf
            "Turn off the car and let the system cool, then drain the flush and water from the cooling system."crlf
            " "crlf
            "9. FLUSH WITH WATER."crlf
            " "crlf
            "If you are not using a flushing additive, or you have completed steps 7 and 8, close the drain valve and fill the system with fresh water."crlf
            "Bring the car up to temperature as described in step 8."crlf
            "When the car is cooled down, drain the new water out and close the drain."crlf
            "If you have the car on jack stands, you can lower it at this time."crlf
            " "crlf
            "10. ADD THE NEW COOLANT."crlf
            "  "crlf
            "Check your owner’s manual for the capacity of your coolant system."crlf
            "If you are using pre-mixed coolant,simply pour it in the radiator and burp the coolant until full."crlf
            "Once burped, reinstall the radiator cap and then fill the reserve tank to the cold level."crlf
            "If you are using a full-strength coolant, mix to your desired ratio with distilled water."crlf
            "It is not necessary to pre-mix the two before filling the system, but put the coolant in first."crlf
            " "crlf
)
)

(deffunction G::Hose ;How to: Replace a Hose

()

(printout cool " "crlf
            "The flexible coolant lines in your engine allow the engine to move and vibrate while the radiator and heater core remain fixed."crlf
            "These hoses need to be changed if they become brittle or spring a leak."crlf
            "The hose clamps that hold the hoses in place can also loosen and leak, and may need to be tightened or replaced."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            "  Replacement hose."crlf
            "  Pan to catch coolant."crlf
            "  Safety gloves and glasses."crlf
            "  Rags."crlf
            "  Tool to remove and install the hose clamps."crlf
            "  Utility knife or razor blade-if needed."crlf
            " "crlf
            "1. DRAIN THE COOLING SYSTEM."crlf
            " "crlf
            "See “How to: Flush and Fill the Cooling System” for information on draining the coolant."crlf
            " "crlf
            "2. LOOSEN THE HOSE CLAMPS."crlf
            " "crlf
            "Using the correct tool for your clamps, loosen the clamps and pull the hose back away from the connection."crlf
            "There is usually an internal lip on the hose connection, and the clamp must be moved past this lip to release the hose."crlf
            " "crlf
            "3. REMOVE THE HOSE."crlf
            " "crlf
            "If the hose has been in place for a long time, it may be stuck."crlf
            "Carefully twist the hose back and forth to wiggle it loose."crlf
            "If it won’t come off, use a utility knife or razor blade to cut it loose."crlf
            "BE AWARE! that excess coolant may run out of the hose as you remove it."crlf
            " "crlf
            "4. INSTALL THE NEW HOSE."crlf
            " "crlf
            "Put the hose clamps on the hose prior to installing it."crlf
            "As you insert the hose onto the connection, give the hose a twist back and forth to help guide it onto the opening."crlf
            "Some outlets will have a little stop on the end push the hose up to this point or push the hose until it sits tight."crlf
            " "crlf
            "5. REINSTALL CLAMPS."crlf
            " "crlf
            "The clamp should be tight enough that you can’t move the hose, but it should not start digging into the hose itself."crlf
            "The hose should bulge up a little bit from the clamp pressure but not much, and the end should not flare outward."crlf
            " "crlf
            "6. REFILL THE COOLANT."crlf
            " "crlf
            "Refill the radiator with the coolant."crlf
            "Check for any leaks before starting the car."crlf
            "If a clamp connection is leaking, check the clamp placement, and replace the clamp if necessary."crlf
            " "crlf
            "7. START THE CAR."crlf
            " "crlf
            "Start the car and bring the engine up to operating temperature."crlf
            "Check for leaks at the connection."crlf
            "After driving for a few days check the clamps to ensure they are still tight."crlf
)
)

