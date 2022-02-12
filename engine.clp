

(deftemplate Check "Common Engine Problems"
  (slot check-engine-light
  (type SYMBOL)
  (allowed-symbols ON OFF)
  )

  (slot appearance
  (type SYMBOL)
  (allowed-symbols amber yellow orange no-color)
  )

  (slot flashing
  (type SYMBOL)
  (allowed-symbols YES NO)
  )
)

(deftemplate Overheating  "Common Engine Problems"
    (slot engine-status
    (type SYMBOL)
    (allowed-symbols hot cold)
    )

    (slot temperature-gauge
    (type SYMBOL)
    (allowed-symbols out-of-range in-range)
    (default out-of-range)
    )
)

(deftemplate Power_loss    "Common Engine Problems"

    (slot valve-status
    (type SYMBOL)
    (allowed-symbols bend straight)
    )

    (slot gasket-status
    (type SYMBOL)
    (allowed-symbols blown okay)
    )
)


(deftemplate Timing_Belts
  (slot  belt-status
  (type SYMBOL)
  (allowed-symbols broken worn okay cracked)
  )
  (slot sound
  (type SYMBOL)
  (allowed-symbols slapping-noise)
  )
)

(deftemplate Drive_Belts "Serpentine belts"
  (slot  status
  (type SYMBOL)
  (allowed-symbols cracked striped)
  )

  (slot sound
  (type SYMBOL)
  (allowed-symbols screeching-noise)
  )
)




(deffunction Checklight "if Causes defrule is activated"
()
 (printout ef "Possible causes:" crlf
             
              "Gas cap is loose:You should tighten it,if lost replace it with a new one" crlf
              " "crlf
              "Oxygen sensor is bad:A new one is required but identify which one is bad first" crlf
              " "crlf
              "Spark plugs are failing:They need replacing" crlf
              " "crlf
              "Your car's mass air flow sensor needs replacing" crlf
              " "crlf
              "The engine's ability to close the cylinder and make compression is hindered" crlf
              " "crlf
              "Engine is overheating,in that case check your coolant and antifreeze" crlf
              " "crlf
              "If it's flashing,a more serious problem is developing:a misfire could be occuring that can overheat the catalytic converter" crlf
              " "crlf
              "These emission devices operate at high temperatures to cut emissions but can pose a fire hazard if faulty" crlf
              " "crlf
              " "crlf
              "NOTE!"crlf
              " "crlf
             "You may confuse the service required or maintenance required light on the gauge cluster for the check engine light" crlf
             " "crlf
             "These warning lights are unrelated."crlf
             " "crlf
            "The service required light just means the car is due for an oil change or other routine care."crlf
            " "crlf
            "It's NOT an indicator of trouble"crlf
            " "crlf

              " "crlf

            "Your preferred mechanic can usually diagnose the problem for you" crlf
              "OR"crlf
             " "crlf
              "You can use a code reader from an auto parts store or online store that connects to the onboard diagnostics port"crlf
              " "crlf
              "You can search for the meaning on websites such as Engine Light Help" crlf
              " "crlf
              "It's worth noting that ONLY cars made from 1996 onwards have the standardized onboard diagnostics OBD for short" crlf
              " "crlf

)
)

(deffunction Power  "If defrule Stop-running is activated"
()
    (printout ef "The engine relies on three things to keep pressure inside the cylinder:"crlf
                " "crlf
                "Valves, which sit hard against the cylinder"crlf
                " "crlf
                "Head gaskets, which are located between the head and block"crlf
                " "crlf
                                "and" crlf
                "Piston rings, which expand between the cylinder wall and the piston." crlf
                " "crlf
                "If one of these fails, your engine will have a loss of power or stop running." crlf
                " "crlf
                "If a valve bends, it won’t be able to seat against the head"crlf
                 " "crlf
                "If a gasket fails, it will release pressure"crlf
                " "crlf
                "If the rings fail, it will force pressure into the bottom of the engine and cause the engine to falter."crlf
                " " crlf
                "When one or more cylinders start to lose compression, the effect is loss of power, vibrations, and stalling of the motor."crlf
                " "crlf
                "A failure in any of these parts can also cause oil or coolant to enter the cylinder, and that will cause engine problems, too." crlf
                " "crlf
                "A professional can run diagnostics on your engine, and will have a tool to check engine compression."crlf
                " "crlf
                "Checking the compression in the cylinders tells your mechanic a lot about what is happening inside the engine without the need to take it apart."crlf
                " "crlf
    )
)

(deffunction AccessoryBelts  "if defrule Belts is activated"
()
      (printout ef"The engine uses a belt, chain, or gears to keep the crankshaft and camshaft working together."crlf
                 " "crlf
                 "Belts and timing chains can stretch or slip over time."crlf
                 " "crlf
                 "Causing the valves to stop opening and closing when they should."crlf
                 "The valves could end up being struck by your engine's pistons" crlf
                 " " crlf
                 "A valve touching the pistons is the biggest problem, and it is expensive to fix."crlf
                 " "crlf
                 "NOTE!"crlf
                 " "crlf
                 "It's important to have your timing belt regularly inspected" crlf
                 " "crlf
                 "Typically,timing belts should be replaced every 60000-86000 km" crlf
                 " "crlf

                 "Changing a timing belt or chain is best handled by an experienced mechanic"crlf
                 " "crlf
                 "Because accessing the belt requires disassembling the engine."crlf
                 " "crlf
      )
)

(deffunction DB  "if defrule Drive is activated"
      ()
      (printout ef "Serpentine belts also known as drive belts provide power to the air conditioning compressor,power steering pump,cooling fan and more" crlf
                  "Like the timing belt, the drive belts will stretch and wear out over time."crlf
                  " "crlf
                  "Belts often fail between 57000 and 87000 km"crlf
                  "On some cars it is easy to change the belt or belts."crlf
                  " "crlf
                  "NOTE!"crlf
                  " "crlf
                  "Your ability to do so depends on how accessible the belts are."crlf

                  "Covers, fans, and other accessories may prevent you from changing it yourself without special tools."crlf
                  " "crlf
                  "More and more manufacturers are putting covers and protective shields on cars, making it difficult to inspect the belts."crlf

                  " "crlf
                  "If it is difficult to properly inspect the belts on your car,"crlf
                  "Have a professional check them at the manufacturer’s recommended intervals."crlf
                  " "crlf
      )
)



(deffunction EngineOil_Procedure "How to check and add engine oil"
  ()
(printout ef  "Checking your engine oil should be a regular routine."crlf
              "For most vehicles, you check your engine oil with a dipstick"crlf
              "The dipstick  reaches down into the oil pan and dips into the oil reservoir."crlf
              " "crlf

              "CHECKLIST:"crlf
              " "crlf
              "Clean rag or paper towel"crlf
              "Engine oil(if needed)"crlf
              "Funnel (optional)"crlf
                " "crlf
             "Checking Engine oil Procedure:"crlf
             " "crlf
             "1. TURN OFF THE ENGINE."crlf
                        " "crlf
                  "You can check the engine oil at any time."crlf
                  "The best is at least five minutes after it has been running and is warm but not hot"crlf
                  "Be CAREFUL not to burn yourself while checking a hot engine."crlf
                     " "crlf
             "2. LOCATE THE OIL DIPSTICK."crlf
                        " "crlf
                  "On some cars it is bright yellow and right up front"crlf
                  "But it may look different on your car"crlf
                       " "crlf
             "3. PULL AND INSPECT THE DIPSTICK."crlf
                           " "crlf
                   "Remove the dipstick from the engine."crlf
                   "Inspect it for anything that doesn’t look like oil"crlf
                            " "crlf
              "WHAT TO LOOK FOR:"crlf
                            " "crlf
                 "Heavily Contaminated Oil:"crlf
                 " "crlf
                 "It’s normal for oil to turn black from the soot of the engine."crlf
                 "What you need to look for is grit and sludge in the oil."crlf
                 "This will make the oil look thicker and heavier than when you put it in."crlf
                 "Clean oil has a brown or dark brown color"crlf
                 " "crlf
                 "White, Milky Foam:"crlf
                 " "crlf
                 "A whitish foam just above the oil level may indicate:"crlf
                 "Antifreeze or condensation has been mixing into the oil."crlf
                 "If the dipstick hasn’t been fully inserted in the tube"crlf
                 "Moisture can run down the dipstick and cause this."crlf
                 "If it is heavy or persistent, you need to have the engine inspected."crlf
                 " "crlf
                 "Metal Particles:"crlf
                 " "crlf
                 "If you see shiny metal flakes in the oil, you may have an engine problem."crlf
                  " "crlf
                 "If you find one of these problems, change your oil and recheck the problem."crlf
                 "If the problem doesn’t go away, take your car to a pro and have it checked."crlf

             " "crlf
             "4. WIPE AND RE-INSERT THE DIPSTICK."crlf
                      " "crlf
                  "Since the engine slings oil onto the dipstick when running"crlf
                  "Use a clean rag or paper towel to wipe the dipstick"crlf
                  "and re-insert it all the way back into the engine."crlf
                      " "crlf
             "5. INSPECT THE ENGINE OIL LEVEL."crlf
                        " "crlf
                  "Pull the dipstick back out to get a fresh reading."crlf
                  "Check that the level falls within the minimum and maximum levels marked on the dipstick."crlf
                  "Ideally, the level should be at but not over the maximum level."crlf
                    " "crlf
                  "NOTE!"
                  " "crlf
                  "CARS WITHOUT DIPSTICKS"crlf
                  " "crlf
                  "Some new cars do not come with an engine oil dipstick."crlf
                  "Instead, they have a sensor that measures the oil level and lets you know if the car needs oil."crlf
                  " "crlf
                  " If your car has this system, it is very important that you change your oil at the recommended intervals and check regularly for leaks."crlf
                  " "crlf

            "ADDING ENGINE OIL:"crlf
                   " "crlf
               "If your engine is healthy and you get regular oil changes."crlf
               "Your oil level shouldn’t get low enough between changes that you need to add oil."crlf
               "If it is consistently low, it usually means it is leaking or burning oil."crlf
               "A very small leak is nothing to be concerned with."crlf
               "But all the more reason to keep an eye on the oil level"crlf
               "If you need to add oil yourself, here’s how to do it:"crlf
               "Be sure to use the type of oil recommended by your manufacturer."crlf
               " "crlf

                "1. LOCATE THE OIL FILL LOCATION."crlf
                 " "crlf
                     "The oil fill is usually on top the engine in one of the valve covers."crlf
                     "If you can’t find it, check the owner’s manual for its location"crlf
                  " "crlf
                "2. POUR IN THE OIL."crlf
                       " "crlf
                     "Use a funnel to prevent drips and splatters that could be mistaken for a leak"crlf
                     " "crlf
                "3. CHECK THE OIL LEVEL."crlf
                       " "crlf
                      "Your owner’s manual or the dipstick may tell you:"crlf
                      "How much oil is between the minimum and maximum levels."crlf
                      "Wait a couple of minutes for the new oil to run down into the oil pan"crlf
                      "And check the engine dipstick again."crlf
                      "Repeat the fill process until the level has reached the maximum line"crlf
                         "  "crlf
                "4. CLEAN AND REPLACE CAP."crlf
                        " "crlf
                      "Make sure you clean any spilled oil from your motor (be careful on a hot engine)"crlf
                      "And replace the cap"crlf
                         " "crlf
)
)


(deffunction Oil_Types
()

(printout ef " "crlf
            "So your mechanic has recommended that you use a synthetic oil."crlf
            " "crlf
            "They say it’s better for your car, but it costs a lot more."crlf
            "Here's the difference:"crlf
            " "crlf
            "CONVENTIONAL OIL"crlf
            " "crlf
            "A petroleum product, which has to be refined"crlf
            "Aftermarket engine parts manufacturers may recommend conventional oil when installing their parts."crlf
            "Conventional oil is less expensive than synthetic oil"crlf
            " "crlf
            "But must be changed more frequently, usually every 4800 to 9600 km."crlf
            " "crlf
            "SYNTHETIC OIL"crlf
            " "crlf
            "Made in a lab, which results in a more stable and, at times, better-performing product."crlf
            "Because synthetics can stand higher heat, some high-performance manufacturers recommend them."crlf
            "Synthetics can go 16,000 to 19,200 km before they need to be changed"crlf
            " "crlf
            "But since they cost three to four times more than conventional oils, the cost savings may be negligible."crlf
            " "crlf
            "Oil makers may also make “blended oil” which use both conventional and synthetic types"crlf
            "To get the advantages of both, but fall between each in performance and ability."crlf
            " "crlf

            "Both conventional and synthetic oils have to meet a government standard"crlf
            " "crlf
            "Car manufacturers also set standards for engine oil based on how the engine is made."crlf

            "Engine oil is rated by its weight (a “W” number, like 30W)."crlf
            " "crlf
            "Thinner oils have lower numbers than thicker oils."crlf
            "Most new cars are designed to use thinner oils, which take less energy to pump,thus saving fuel"crlf
            " "crlf
            "If you’re using the manufacturer’s recommended grade of oil, your car will operate just fine."crlf
            "A mechanic may recommend synthetic:"crlf

            "If you aren’t getting your oil changed frequently enough or if you do some highperformance driving."crlf
             " "crlf
             "If you change your oil on a regular basis, conventional oil is sufficient"crlf
             " "crlf
             "Consider a synthetic if you’re forgetful, have a lead foot(tendency to drive excessively fast), or like the added protection."crlf
             " "crlf
)
)

(deffunction Oilgauge_reading "Correct reading of oil gauge"
()
(printout ef " "crlf
            "READING YOUR OIL GAUGE"crlf
            " "crlf
            "The oil light or gauge measures the oil pressure as oil is pumped through the engine."crlf
            "Too little pressure means the oil may not be reaching the parts to lubricate them"crlf
            "And too much pressure may indicate a blockage."crlf
            " "crlf
            "Both situations are very bad for your engine."crlf

            " "crlf
            "Some cars use a light, and some cars use a gauge to tell you about the oil pressure."crlf
            "If you see the light come on, or if you see the gauge go up too high or too low,"crlf
            "Bring your car to a stop as soon as safely possible."crlf
            "Check the level of your engine oil."crlf
            " "crlf
            "DO NOT! drive a car with low oil pressure, you will damage the engine"crlf
            "If the engine oil is very low, refill the engine oil and re-check the gauge while the engine is running."crlf
            " "crlf
            "If the problem goes away, check for leaks or oilburning smoke from the exhaust."crlf
            "Have the car checked by a professional as soon as possible."crlf
            " "crlf
            "Please,if you find any other problems:"crlf
            "DO NOT! drive the car, have it towed to a repair garage immediately."crlf
)
)

(deffunction ChangingOil
()
(printout ef " "crlf
            "How to: Change the Engine Oil"crlf
            " "crlf
            "Changing your own engine oil is a good way to save money"crlf
            "But before you begin, check local regulations to make sure it’s legal for you to do it yourself"crlf
            "Recycling oil is a must, and items like the used filter may require proper disposal."crlf
            "Finally, keep in mind that changing oil is a messy job and your filter may be difficult to access,"crlf
            " "crlf
            "Be prepared to get dirty."crlf
            " "crlf
            "WHAT YOU NEED"crlf
            " "crlf
            "Oil recommended by your manufacturer"crlf
            "Oil filter appropriate for your car"crlf
            "Paper towels"crlf
            "Oil pan"crlf
            "Tool to remove the oil drain plug (usually a wrench)"crlf
            "Jack and jack stands (if needed)"crlf
            "Funnel (optional)"crlf
            "Oil filter wrench (if needed)"crlf
            " "crlf
            "PROCEDURE"crlf
            " "crlf
            "1. LOCATE THE OIL FILTER."crlf
            " "crlf
            "With the engine cold, locate the oil filter."crlf
            "Make sure you can access it easily."crlf
            "Take note of the style of filter your car uses."crlf

            "There are several filter types: the most common are cartridge and spin-on filters."crlf
            " "crlf

            " 2. PREP THE CAR."crlf
            " "crlf
            "Find a safe, level place to change your oil."crlf
            "Make SURE! your car is in “park” or in gear and set the emergency parking brake to prevent the car from moving."crlf
            "If your car is low to the ground, you may need to raise the car up:"crlf
            "to gain access to the drain plug and filter"crlf
            " "crlf

            "3. LOCATE THE DRAIN PLUG."crlf
            " "crlf
            "The drain plug is located at the lowest point on the engine."crlf
            "It usually looks like a bolt"crlf
            " "crlf

            "4. REMOVE THE DRAIN PLUG AND DRAIN THE OLD OIL."crlf
            " "crlf
            "Place your oil drain pan under the plug."crlf
            "Remove the plug with your wrench."crlf
            "BE CAREFUL!: the oil will drain fast and can splatter easily"crlf
            "Adjust the position of the pan if needed as the ﬂow of oil slows."crlf
            "Allow the oil to drain completely"crlf
            " "crlf

            "5. INSPECT THE DRAIN PLUG."crlf
            " "crlf
            "Before you reinstall the plug, inspect it for damage or contaminants."crlf
            "Clean the plug and threads before reinstalling"crlf
            " "crlf
            "6. REINSTALL THE DRAIN PLUG."crlf
            " "crlf
            "Reinstall the drain plug and tighten."crlf
            "BE CAREFUL NOT to overtighten the plug and strip the threads"crlf
            " "crlf

            "7. REMOVE THE OIL FILTER"crlf
            " "crlf
            "Removing the oil filter can be tricky."crlf
            "You may be able to do it by hand."crlf
            "or you may need to use a special oil filter wrench."crlf
            "Place your oil drain pan under the filter in case of leaks."crlf
            " "crlf
            "8. INSPECT THE FILTER."crlf
            " "crlf
            "Once you have the filter off and away from the car, look it over."crlf
            " On a spin on filter, you can’t see the inside,"crlf
            "but you can check the opening for metal shavings or debris from the engine."crlf
            "Check that the gasket on the filter is intact and hasn’t stuck to the engine"crlf
            " "crlf

            "USING A FILTER WRENCH."crlf
            "If your filter will not come off by hand, you may need to use a special oil filter wrench."crlf
            "These are available in several different styles."crlf
            "If you try a wrench and you still can’t get the filter off, you can put the old engine oil back in the motor,"crlf
            " seal it up, and take it to a professional."crlf

            " "crlf
            " 9. CLEAN THE GASKET SURFACES."crlf
            " "crlf
            "The gasket surfaces need to be cleaned before installing the new filter."crlf
            "On a spin-on filter, use paper towels to wipe off the ﬂat surface:"crlf
            "on the engine where the filter gasket touches the engine"crlf
            "On a cartridge filter, check the bottom of the canister for contaminants"crlf
            "Use a paper towelor clean piece of cloth to wipe them out"crlf
            "BE CAREFUL! not to leave any paper towel or any other foreign object in the canister"crlf
            "Clean the threads on the top of the canister"crlf

            " "crlf
            "10. LUBRICATE THE NEW GASKET."crlf
            " "crlf
            "For a spin-on filter:"crlf
            "smear a small amount of new engine oil on the entire mating surface"crlf
            "of the new gasket before re-installing it on the engine."crlf
            "This will help seal the filter and make it easier to remove on the next oil change"crlf
            " "crlf
            "For a cartridge filter, snap the new filter into the top cap:"crlf
            "use a small amount of oil to coat all the gaskets"crlf
            "Most cartridge-type filters will come with a new O-ring gasket for the cap."crlf
            "Install the new O-ring and coat it with some clean oil to help seal the gasket and make removal easier next time."crlf
            " "crlf
            "TIP:CHOOSING AN OIL FILTER."crlf
            " "crlf
            "1. Changing your oil on a regular basis is more important than what type of filter you use."crlf
            "2. Premium price does not always mean a premium product."crlf
            " However, if you change your filter regularly, any well-known brand of filter will work just fine."crlf
            "3. Avoid very low cost and no-name filters."crlf
            " "crlf

            "11. INSTALL THE NEW FILTER."crlf
            " "crlf
            "A spin-on filter is designed to be tightened by hand."
            "To install a spin-on filter properly, screw the filter on the mount until you feel the gasket touch the mounting surface."crlf
            "At this point, turn the filter approximately three-quarters of a turn."crlf
            "PLEASE, check the packaging for specific instructions."crlf
            " "crlf
            "For a cartridge filter, screw the filter cap on by hand:"crlf
            "Until the gasket fully seats and then snug the cap."crlf
            "DO NOT! overtighten you can tear or ruin the gasket."crlf
            " "crlf
            "TIP"crlf
            "Some people recommend that you put oil in the new filter before installing it,"crlf
            "so it isn’t dry when you start the motor."crlf
            "It’s fine to do this, but if your filter is mounted at an angle it can make a mess."crlf
            "If your oil pump is functioning properly, the new filter will be filled within a few seconds."crlf
            "So pre-filling it isn’t really necessary."crlf
            " "crlf
            "12. POUR IN THE NEW OIL."crlf
            "Once the new filter and plug are back in the engine,"crlf
            "remove the oil cap and pour in the recommended amount of motor oil"crlf
            "Using a funnel helps to prevent spills"crlf
            "Wipe up any spilled oil and replace the oil cap."crlf
            " "crlf
            "13. CHECK FOR LEAKS."crlf
            "Before starting the engine, check under the car for any drips."crlf
            "From the drain plug or from the oil filter."crlf
            "Turn on the car and let it run for a minute or two and check under the car for leaks."crlf
            " "crlf
            " 14. REMOVE THE CAR FROM JACKS, IF NEEDED."crlf
            " "crlf
            "Once you are sure you don’t have to get back under the car."crlf
            "You can lower the car off the safety jacks."crlf
            " "crlf
            " 15. RESET YOUR COMPUTER IF NECESSARY."crlf
            " "crlf
            "Some vehicles come with a vehicle data center that includes a feature that tells you when to change your oil."crlf
            "The step for resetting this feature should be in your owner’s manual."crlf
            "If you don’t have a reminder,"crlf
            "note the mileage and date when you performed the oil change and keep that information safely"crlf
            " "crlf
            "IF YOU FOLLOWED THE ABOVE STEPS CORRECTLY YOU ARE GOOD TO GO!"crlf
            " "crlf
            "PROPERLY DISPOSING OF ENGINE OIL AND FILTERS."crlf
            " "crlf
            "If you change your own oil, you must know how to properly dispose of the used oil and filter."crlf
            "Regulations differ, so it’s important that you know the rules in your area."crlf
            "In some places, you can put the used oil in your empty oil containers and take it to an auto parts store."crlf
            "Where they will recycle the old oil for free."crlf
            " "crlf
)
)

(deffunction Inspect "How to: Inspect and Change Accessory Belts"
()
(printout ef " "crlf
            "The accessory belts are spun by the engine to drive features such as the alternator, power steering, and water pump."crlf
            "It is usually a serpentine belt that winds around several pulleys on the front of the engine."crlf
            "It will stretch over time, and can fail as the internal cords give way,"crlf
            "or it cracks and breaks due to age."crlf
            "Belts with cracks, stretching, or fraying need to be replaced."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            " "crlf
            "1.Replacement belt"crlf
            "2.Tools to remove the belt and any accessories in your way (usually a socket wrench or socket)"crlf
            "3.Safety gloves and glasses."crlf
            " "crlf
            "The first sign of trouble with a belt is usually the noise."crlf
            "As a belt wears out, it loses tension and starts to slip against the pulleys it is driving."crlf
            "This creates a loud squealing noise."crlf
            " "crlf
            "INSPECTING THE BELTS"crlf
            " "crlf
            "1. LOCATE THE BELTS."crlf
            " "crlf
            "On most vehicles, the accessories are run opposite of the transaxle or transmission."crlf
            "This is usually on the left side or the front of the engine."crlf
            "BE AWARE that the belts may be obscured by a plastic cover "crlf
            " "crlf
            "2. INSPECT THE BELTS WITH ENGINE RUNNING."crlf
            " "crlf
            "With the engine running, watch the belt."crlf
            "Look for any kind of side-to-side wobble from the pulleys,"crlf
            "or a noticeable wear point as the belt goes around."crlf
            " "crlf
            "CAUTION!"crlf
            "Keep hands and other items away from the running motor."crlf
            " "crlf
            "3. INSPECT THE BELTS WITH ENGINE OFF."crlf
            " "crlf
            "With the engine off, you can get a closer inspection of the belts."crlf
            "Put on your safety gloves and glasses."crlf
            "BE CAREFUL! when inspecting a warm or hot engine."crlf
            " The belts can wear on the inside and outside surfaces."crlf
            "On the smooth side, look for evidence of slipping and grooves."crlf
            "If it looks shiny it may be slipping."crlf
            " "crlf
            "Deep grooves in the smooth side might denote a problem with one of the pulleys and a belt that is off center"crlf
            "On the grooved side, look for evidence of missing grooves or other damage."crlf
            "Any sign of reinforcement cords is a warning sign that the belt is failing."crlf
            " "crlf
            "On both sides, look for internal belt cords and cracking."crlf
            "If you find any you will need to have the belt replaced."crlf
            " "crlf
            "CHANGING THE BELTS"crlf
            " "crlf
            "All cars are different, and how you change your accessory belt will depend in part on how it is built."crlf
            "Some cars have belts that are very easy to access, while others are much more difficult."crlf
            " "crlf
            "1. LOCATE THE BELT DIAGRAM."crlf
            " "crlf
            "Most car makers put a sticker somewhere under the hood to show you how the belt is meant to be installed on the car."crlf
            "If your car does not have a label, make a diagram or take a picture."crlf
            "So you will know how it should look when you replace the belt."crlf
            " "crlf
            "2. REMOVE THE BELT."crlf
            "Most engines use a spring-loaded tensioner that keeps a belt tight as it wears and stretches."crlf
            "Some tensioners have an adjustment bolt that applies tension."crlf
            "If you pull the tensioner back, the belt will slacken and you can remove the belt."crlf
            "Pull the tensioner back to release the pressure on the belt and remove the belt."crlf
            "Once the belt slackens, you can pull it off with your hands."crlf
            "It may be a challenge to guide the belt around different parts to remove it from the engine."crlf
            " "crlf
            "TIP:"crlf
            " "crlf
            "When an engine throws a belt and it hasn’t broken or stretched too far,"crlf
            "it is possible that one of the pulley bearings is wearing out and the belt is sliding off of the pulley."crlf
            "Check your pulleys for proper straight alignment."crlf
            "Any kind of offset alignment will reduce the life of the belt and possibly cause it to come off the motor."crlf
            "Inspect the engine while it is running for any kind of wobble in the belt system."crlf
            " "crlf
            "STRETCH BELTS:"crlf
            " "crlf
            "Some manufacturers use stretch belts to eliminate the spring-loaded tensioner."crlf
            "A stretch belt works like a big rubber band, and requires a special tool to install and remove it."crlf
            "If the vehicle has stretch belts, use the proper tool for installation and removal."crlf
            "Using a screwdriver or other tool can DAMAGE! the belt."crlf
            " "crlf
            "3. INSPECT THE PULLEYS."crlf
            " "crlf
            "With the belt off of the engine, give the pulleys a spin to make sure they spin freely and don’t wobble."crlf
            "Wobble will cause the belts to come off of the engine."crlf
            "If you see wobble or if you feel grinding or grit as the pulleys turn,"crlf
            "You will need to have the pulley or bearings replaced by a professional."crlf
            " "crlf
            "4. INSTALL THE NEW BELT."crlf
            " "crlf
            "If your pulleys are okay, you can route the new belt using your diagram as a guide."crlf
            "Route all the paths up to the tensioner."crlf
            "Pull the tensioner back and install the belt, and then release the pressure on the tensioner."crlf
            "Inspect all the points where the belt meets each pulley:"crlf
            "to make sure it is properly aligned."crlf
            " "crlf
            "5. CHECK THE BELT."crlf
            " "crlf
            "After you have installed the belt, run the engine and observe the belt as it moves."crlf
            "It should move smoothly over all the pulleys with no wobble."crlf
            " "crlf
)
)



(defrule Causes


(Check (check-engine-light  ON) (appearance orange|amber|yellow) (flashing YES))

  =>

(Checklight)

)




(defrule Stop-running
 (Power_loss(valve-status bend) (gasket-status blown))
 =>
(Power)
)



(defrule Belts
   (Timing_Belts(belt-status broken|worn|cracked) (sound slapping-noise))
   =>
(AccessoryBelts)
)

(defrule Drive
  (Drive_Belts(status cracked|striped) (sound screeching-noise))
  =>
(DB)
)





