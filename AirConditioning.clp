
(defmodule H (export ?ALL))



(deffunction H::AC-Working ;How the A/C System Works

()

(printout ac " "crlf
            "The air-conditioning system in your car consists of a condenser, a radiator, an evaporator, a compressor, and an accumulator, as well as a network of hoses,switches, and sensors."crlf
            "It works by taking liquid refrigerant and pushing it through a valve to turn it into a gas, which dramatically lowers the temperature of the refrigerant."crlf
            "In gas form, the refrigerant absorbs the heat from the surrounding air, making the air cold, and the cold air is blown into the vehicle cabin."crlf
            " "crlf
            "Due to the complexity of the A/C system and the special equipment required to service it, all repairs should be done by a qualified technician."crlf
            " "crlf
            "Basic components of the A/C system:"crlf
            " "crlf
            "Compressor:"crlf
            "   The compressor is a big air pump that is usually run from a belt on the engine."crlf
            "   The compressor takes in the refrigerant usually Freon® as a vapor and compresses it."crlf
            "   The gas heats up as it is compressed, resulting in heat and high pressure vapor."crlf
            "   The compressor doesn’t run all the time, so the pulley on the front of it usually has a magnetic clutch that can be turned on and off, as needed."crlf
            " "crlf
            "Condenser:"crlf
            "   This piece is usually mounted in front of the radiator."crlf
            "   It uses the air that is drawn through the front of the car to lower the temperature of the refrigerant below its boiling point and turn it back into a liquid."crlf
            " "crlf
            "Expansion Valve:"crlf
            "   This valve lets the liquid pass at a lowered pressure and causes something called “flash expansion,” which reduces the temperature of the refrigerant and makes it nice and chilly."crlf
            "   Newer systems use an orifice tube,but they perform the same function."crlf
            " "crlf
            "Accumulator:"crlf
            "   Moisture in the A/C system is a problem, so most systems have something to keep the system dry."crlf
            "   This may be called an accumulator, a drier, or a receiver."crlf
            "   It is usually a cylinder mounted somewhere under the hood and in addition to removing moisture it also acts as a reservoir for the liquid refrigerant when it’s not needed."crlf
            " "crlf
            "Evaporator:"crlf
            "   This component is usually mounted under the dash and attached to a fan."crlf
            "   As the cooled liquid/vapor mix runs through the evaporator, the fan blows air over the fins, which transfers warmth from the air to the refrigerant, which then cools the cabin air."crlf
            " "crlf
)
)

(deffunction H::AC_Problems;Common A/C System Problems
()

(printout ac " "crlf
           "Common A/C System Problems:"crlf
           crlf
           "The first indication of a problem with the air conditioner is that it stops blowing cold air."crlf
           "The A/C system is meant to be completely sealed, and when problems arise, it is usually due to gas escaping from the system or contaminants getting into it."crlf
           crlf
           "LEAKS:"crlf
           "      The compressed gases in the A/C system require seals and valves, and over time these will degrade."crlf
           "      Pinholes in metal lines can be a problem, too."crlf
           "      You can add more refrigerant to the A/C system, but the problem will eventually get worse."crlf
           " "crlf
           "COMPRESSOR FAILURE:"crlf
           "      Major leaks lead to catastrophic problems, like compressor failures."crlf
           "      This can happen when the magnetic clutch on the compressor fails, which prevents the compressor from spinning, or the clutch fails to release and the compressor runs all the time."crlf
           " "crlf
           "PRESSURE PROBLEMS:"crlf
           "      Most issues with the A/C system can be diagnosed with the use of a set of gauges."crlf
           "      The gauges read the pressure on both the high- and low-pressure sides of the system."crlf
           "      Most of the time, checking the low pressure side is enough to tell you if you need professional assistance."crlf
           " "crlf
           "UNPLEASANT ODOR:"crlf
           "      Since the air conditioning exchanges cold and hot air, condensation forms on the condenser located under the dash."crlf
           "      This drips off and runs out of a drain located at the bottom to the box that holds the condenser."crlf
           "      If the drain becomes clogged,it creates a cool, moist area for mold and other unpleasant-smelling things to grow."crlf
           " "crlf
           "CLOGGED FILTER:"crlf
           "      Newer cars may have a cabin filter to clean the air as it passes through the heater and A/C system."crlf
           "      It is usually located under the dash on the passenger side or under a panel in the engine compartment."crlf
           "       The filter may become clogged, causing odor or limited performance of the A/C and heater system."crlf
           " "crlf
)
)

(deffunction H::LeakCheck;How to: Check for Leaks

()

(printout ac" "crlf
            "How to: Check for Leaks"crlf
            crlf
            "Finding leaks in a modern air-conditioning system is difficult."crlf
            "The engine bays are crowded, making it hard to see, and the liquid refrigerant becomes an invisible gas when it escapes."crlf
            "However, there are a few tricks you can use to locate a leak."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            "    Soapy Water"crlf
            "    Refrigerant dye"crlf
            "    UV light"crlf
            " "crlf
            "First, familiarize yourself the components of your air-conditioning system and locate them in your car."crlf
            "Once,you have located one or two of the components, trace all the hoses and lines that connect them and look for leaks using one or more of the following methods."crlf
            crlf
            "     The “Wet Look” Test :The compressor is lubricated with oils, and some of these oils are carried harmlessly through the system."crlf
            "     When they come to a leak,the oils get pushed out along with the refrigerant."crlf
            "     The refrigerant isn’t detectible, but the oils are."crlf
            "     Look for an oily “wet look” around a seal or connection that may indicate a leak."crlf
            " "crlf
            "     Soapy Water: You can also check for leaks by mixing up some soapy water and applying it to the A/C lines and ports with a towel, paint brush, or your fingers."crlf
            "     If you get lucky, the leak will start creating bubbles as the gas escapes."crlf
            "  "crlf
            "     UV Dye :Another way to check for leaks is to insert a dye into the system and use a UV light to detect the dye."crlf
            "     Some refrigerants come with the dye already in them, and the UV light is a relatively inexpensive purchase."crlf
            "     Add the dye to the low pressure side as you would add refrigerant and then run the system, allowing the dye to be pushed through the lines."crlf
            "     Shine the UV light on the lines, looking for traces of dye that would indicate a leak."crlf
            " "crlf
)
)


(deffunction H::RefrigerantAdd;How to: Add Refrigerant

()

(printout ac " "crlf
            "If your air conditioner starts working erratically or isn’t cooling properly, you may be low on refrigerant."crlf
            "This is likely due to a leak, which you should have checked by a professional."crlf
            "However, for a short-term solution, you can recharge the system by “topping off ” the refrigerant yourself."crlf
            "Before you begin, be sure to check your local laws."crlf
            "Recharging your A/C system is not allowed in some areas."crlf
            " "crlf

            "WHAT YOU NEED:"crlf
            "  Low-pressure refrigerant gauge."crlf
            "  Appropriate refrigerant for your vehicle."crlf
            " "crlf
            "1. CHECK THE COMPRESSOR:"crlf
            " "crlf
            "With the car running and the air conditioning set to its maximum output,open the hood and observe the air conditioning compressor clutch."crlf
            "If the compressor shuts off after a couple of seconds or never spins at all, the system is probably detecting a low refrigerant level."crlf
            " "crlf
            "2. DETERMINE THE RIGHT REFRIGERANT FOR YOUR CAR:"crlf
            " "crlf
            "Look for a label under the hood that shows the type of refrigerant used in your vehicle."crlf
            "This may be on the radiator support or on the underside of the hood."crlf
            "  "crlf
            "3. GATHER YOUR EQUIPMENT:"crlf
            " "crlf
            "You will need a low pressure port gauge and refrigerant."crlf
            "Refrigerant is packaged in several ways."crlf
            " "crlf
            "4. LOCATE THE LOW-PRESSURE PORT:"crlf
            " "crlf
            "There are two ports, or valves, on the A/C system."crlf
            "One is on the high-pressure side and one is on the low-pressure side."crlf
            "The ports should be located near the top of the engine compartment."crlf
            "The low-pressure port will be between the evaporator and the compressor."crlf
            " "crlf
            "5. CONNECT YOUR GAUGE:"crlf
            " "crlf
            "Twist off the cap from the low-pressure port."crlf
            "Pull the ring on the connection hose back and press the connector onto the port."crlf
            "You may hear some refrigerant leak—try not to let too much out."crlf
            "Release the ring and the connector should seal against the port."crlf
            " "crlf
            "6. START THE CAR AND TURN ON THE A/C:"crlf
            " "crlf
            "With the car running, set the air conditioning to its maximum output."crlf
            " "crlf
            "7. CHECK THE GAUGE:"crlf
            " "crlf
            "If the pressure is slightly below normal, you can add refrigerant."crlf
            " CAUTION!"crlf
            "         DO NOT add refrigerant to a full system."crlf
            "         Overfilling the system will cause problems."crlf
            "         If your gauge is reading extremely low, or doesn’t read any pressure at all, do not add refrigerant."crlf
            "         You have a major leak that needs to be addressed by a professional."crlf
            " "crlf
            "8. ADD REFRIGERANT:"crlf
            " "crlf
            "Open the valve on the can of refrigerant and allow it to flow until the compressor is running and the gauge reads “Full”."crlf
            " "crlf
            "9. REMOVE THE CONNECTOR:"crlf
            " "crlf
            "Pull back the lock ring and pull the connector from the port."crlf
            "Replace the port cap."crlf
            "Check the pressure after a day or two to see if the system has lost pressure."crlf
            "If it has, you have a significant leak that needs to be addressed by a professional."crlf
            " "crlf
)
)

(deffunction H::SmellyAC;How to: Clean a Smelly A/C System

()

(printout  ac crlf
            "Smells in the A/C system can be caused by two things: mold or a leaking heater core."crlf
            "If the smell is musty and unpleasant, like dirt or rotting leaves, you may have a mold problem."crlf
            "This could be due to a clog in the A/C box drain. If the smell is “sweet” like antifreeze, you may have a heater core leak."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            " "crlf
            "   Pressurized air or a blunt instrument to clear the A/C box drain."crlf
            "   Disinfectant spray or mold-killing spray."crlf
            " "crlf
            "LOCATE THE SOURCE:"crlf
            " "crlf
            "Before you can get rid of the smell, you need to figure out what’s causing it. Cleaning and deodorizing will take care of mold smells, but a leaking heater core will need to be replaced."crlf
            " "crlf
            "1. CHECK THE CARPET BELOW THE DASH."crlf
            " "crlf
            "Depending on how the condenser box was designed, heavy leaks can drip down onto the carpet."crlf
            "Since the box is usually on the passenger side, check the carpet by the foot base for leaks from the A/C box."crlf
            "If you find a leak that smells like antifreeze, you will need to have the heater core replaced."crlf
            "If you find a water leak or smell mold, then the drain may be clogged."crlf
            " "crlf
            "2. CHECK THE A/C BOX DRAIN."crlf
            " "crlf
            "The drain is located at the bottom of the box and drains out under the car, usually in the transmission tunnel or near the middle of the car."crlf
            "You may have to lift the vehicle up safely to view the drain."crlf
            "Look for signs of anti-freeze dripping from the drain."crlf
            "The only thing that should be draining out should be water."crlf
            "If A/C has been running and you don’t have condensation dripping out of the drain, it may be clogged."crlf
            " "crlf
            "3. REMOVE OBSTRUCTIONS."crlf
            " "crlf
            "Professionals use pressurized air to clear a clogged drain."crlf
            "If the drain hole is fairly straight and you don’t have access to compressed air, you can try a blunt instrument like the eraser end of a pencil to gently move an obstruction."crlf
            "Do not use coat hangers or anything that might puncture the inside of the A/C box."crlf
            " "crlf
            "GET RID OF MOLD SMELLS"crlf
            "In order to get rid of a moldy smell, you need to spray a disinfectant onto the condenser to kill the mold growing on it."crlf
            "There are commercial-grade products made specifically for this purpose, or you can use a household disinfectant."crlf
            " "crlf
            "1. TURN THE CAR ON AND RUN THE A/C AT MAXIMUM."crlf
            crlf
            "Turn the A/C on full and turn off the recirculating system-usually shown as a picture of your car with air circling around inside."crlf
            "This will allow the A/C to cool with fresh air that’s drawn from the outside the car."crlf
            crlf
            "2. SPRAY THE A/C INTAKE WITH DISINFECTANT."crlf
            crlf
            "With the car running, spray the disinfectant into the intake of the A/C system."crlf
            "This is usually located just under the windshield."crlf
            "If your car is equipped with a cabin filter (check your owner’s manual), remove the filter before spraying the inlet."crlf
            crlf
            "3. SPRAY THE CABIN DUCTS."crlf
            crlf
            "Turn the A/C system and fan off and spray sanitizer into each of the interior A/C outlets."crlf
            "Let it sit for a while before restarting the A/C system."crlf
            crlf
            "4. REPLACE YOUR CABIN FILTER."crlf
            crlf
            "If you removed your cabin air filter, replace it with a new filter."crlf

            crlf
            crlf
            "It may take several rounds before the smell goes away."crlf
            "Keep an eye on the drain—if it keeps clogging you will need a professional to remove it and clean it out."crlf
)
)
