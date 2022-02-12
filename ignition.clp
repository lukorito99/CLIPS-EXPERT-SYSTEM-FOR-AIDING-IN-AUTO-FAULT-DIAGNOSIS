


(deftemplate Plug ;Common symptoms of failing spark plugs

(slot acceleration
(type SYMBOL)
(allowed-symbols sluggish irregular normal)
)

(slot fuel-consumption
(type SYMBOL)
(allowed-symbols increased optimum)

)

(slot idle
(type SYMBOL)
(allowed-symbols rough smooth)
)

(slot starting
(type SYMBOL)
(allowed-symbols hard easy)
)

(slot engine-misfire
(type SYMBOL)
(allowed-symbols YES NO)
)

)


(deffunction Ignition-working "How the Ignition System Works"
()
(printout ig " "crlf
            "Any kind of fire requires three things: fuel, air, and an ignition source."crlf
            "With the exception of electric vehicles and diesel engines, most engines use a spark to ignite the fuel and air inside the engine."crlf
            " "crlf
            "The ignition system in your car is designed to ignite the air-and-fuel mixture at the right time."crlf
            "When the engine has compressed the mixture and it is ready to explode and drive the engine in a rotating motion."crlf
            "To do this, it uses a high-voltage spark that is timed to the engine through the computer or, in older cars, through a mechanical device called a distributor."crlf
            " "crlf
            "Spark Plug"crlf
            "  Spark plugs generate the spark that ignites the air-fuel mixture in the combustion chamber."crlf
            "  This voltage is measured in tens of thousands of volts, so you want to be careful around spark plugs while the engine is running."crlf
            "  Some engines have more than one spark plug per cylinder to help burn the fuel and air more efficiently."crlf
            " "crlf
            "Ignition Coil"crlf
            "  The ignition coil builds up an electrical charge, as much as 50,000 volts, to trigger the spark in the spark plug."crlf
            "  Older, non-computerized cars use a coil that requires a distributor to help send the voltage to the right spark plug."crlf
            "  Newer cars use a coil pack—the computer tells it which cylinder to send the spark to."crlf
            "  The coil-on-plug COP,sits right on the individual spark plug and only fires when that spark plug(s) needs power."crlf
            " "crlf
            "Spark Plug Wires"crlf
            "  The spark plug wires are responsible for transferring the high voltage from either the coil pack or the distributor to the spark plug."crlf
            "  Typical wire construction uses a metal contact that snaps over the end of the spark plug to make a good connection."crlf
            " "crlf
            "Distributor"crlf
            "  The distributor is responsible for sending or distributing the high voltage from the ignition coil to the spark plugs in the correct order."crlf
            "  Older vehicles use a traditional distributor that is connected to the camshaft through a gear."crlf
            "  It rotates around, dispensing the voltage to the spark plugs in sequence through the distributor cap."crlf
            " "crlf
            "CPS"crlf
            "  Instead of a distributor, newer cars use a camshaft position sensor-CPS."crlf
            "  It does the same thing as the distributor, but it sends a signal to the computer when it senses the engine is in the right place."crlf
            "  And the computer then knows when to trigger the coil or coils."crlf
            "  The computer may also use a crankshaft position sensor along with the camshaft sensor to further refine when to trigger the spark plug."crlf
            " "crlf
            "DIESEL ENGINES."crlf
            " "crlf
            "Diesel engines do not use spark plugs."crlf
            "Instead,once the engine is warmed up, they ignite due to the the heat of the compressed fuel,which is under much greater pressure than in a normal petrol engine."crlf
            "When the engine is cold, diesel engines use glow plugs to help trigger ignition."crlf
            "A timer or computer turns off the glow plug when the engine can run on its own."crlf
            " "crlf
)
)

(deffunction General "Message on common ignition system problems"
()
(printout ig  " "crlf
             "Most ignition problems fall into two categories: either the ignition doesn’t trigger at the right time:a timing issue."crlf
             "Or something is preventing the spark from having a full charge: a resistance or failure of the system."crlf
             " "crlf
             "In the old days, it wasn’t possible to detect ignition problems until the car began running poorly."crlf
             "In a modern engine, the computer can sense ignition problems."crlf
             "It uses oxygen sensors to evaluate the air-to-fuel ratio of the engine output."crlf
             "Some engines also have a sensor to detect if the engine is firing too soon:anti-knock sensor and to tell if the engine is misfiring by checking the motion of the crankshaft."crlf
             " "crlf
)
)

(deffunction IgnitionFail "Signs of a failing ignition"

()

(printout ig " "crlf
            "If car won't start:"crlf
            " "crlf
            "You may get your vehicle to start cranking its engine, but it will usually be pretty slow if the ignition is having trouble."crlf
            "This is often because of corrosion on the electrical circuit directly related to the ignition system that is preventing the proper amount of electricity to flow."crlf
            " "crlf
            "If key not turning:"crlf
            " "crlf
            "First of all be sure that the ignition lock is not engaged by turning the steering wheel back-and-forth."crlf
            "If the key will still not turn there may be excessive wear inside the ignition that is preventing the key from properly aligning with the keyhole."crlf
            "If the key cannot be turned your car will not start."crlf
            "Seek for professional help."crlf
            " "crlf
            "If Stalling:"crlf
            " "crlf
            "It will most often happen when your vehicle is traveling down the road, not while sitting idle."crlf
            " "crlf
            "If no noise from starter motor:"crlf
            " "crlf
            "If you turn the key and nothing happens there's a chance that the ignition switch is not able to create the necessary electrical pathway to get power from the battery to the starter motor."crlf
            "While this could also be caused simply by a dead battery you can test this by seeing if other accessories in the vehicle work, such as the radio or power windows, when the key is in the on position."crlf
            "If the battery is not dead there's a good chance that it is caused by an ignition issue."crlf
            "  "crlf
)
)


(deffunction Changing-spark-plugs
()
(printout ig " "crlf
            "Changing your own spark plugs can be easy or difficult,depending on where the plugs are located."crlf
            " "crlf
            "Spark plugs are always located on the cylinder head, but the position can vary."crlf
            "They can be on the top or on the side of the engine, they may be covered by a spark plug wire or a coil."crlf
            "Or they may be under a cover, and there could be more than one spark plug per cylinder."crlf
            " "crlf
            "How to:Change the Spark Plugs."crlf
            " "crlf
            "Changing your own spark plugs can be easy or difficult,depending on where the plugs are located."crlf
            "Make sure you have access to your spark plugs before you begin."crlf
            " WHAT YOU NEED:"crlf
            " "crlf
            "Spark plugs"crlf
            "Socket, wrench,and extension,if needed."crlf
            "Spark plug gap tool."crlf
            "Anti-seize compound."crlf
            "Torque wrench."crlf
            "Tools to remove the coil on-plug,if needed."crlf
            "Safety gloves."crlf
            " "crlf
            "1. LOCATE YOUR SPARK PLUGS."crlf
            " "crlf
            "With the engine cold, locate the plugs and determine whether you can reach them easily."crlf
            "Even if you can see them, there may be other things in your way that will prevent you from getting to all the plugs."crlf
            " "crlf
            "2. REMOVE THE SPARK PLUG."crlf
            " "crlf
            "Pull one spark plug wire at a time."crlf
            "The wire should pull off by hand, or you can use special spark plug wire pliers."crlf
            "If you have coil-on plugs,unscrew one coil at a time and disconnect the electronic connector."crlf
            "With the wire or coil out of the way, use the spark plug socket and wrench to remove the plug."crlf
            "Once the plug is out, inspect it for any kind of damage or abnormal wear."crlf
            "Don’t pull them all at once—if you find one with a problem, you may not put it back in the correct cylinder."crlf
            " "crlf
            "3. CHECK THE GAP ON YOUR NEW PLUGS."crlf
            " "crlf
            "Before installing your new plugs,check that the gap between the two electrical points is correct."crlf
            "Using a spark plug gap tool or feeler gauge, insert the tool between the post and metal L-shaped bar."crlf
            "The tool should slide in and out but not have any space between the tool and metal points."crlf
            "If you need to adjust the distance, you can very gently bend the L-shaped bar in or out and retry the gap."crlf
            " "crlf
            "4. APPLY ANTI-SEIZE GREASE."crlf
            " "crlf
            "Dab a little anti-seize compound on the plugs before installing them in the engine."crlf
            "This will help to prevent the plugs from becoming stuck and stripping the threads when they need to be removed."crlf
            " "crlf
            "5. INSTALL THE NEW PLUGS."crlf
            " "crlf
            "Insert the new plug into the engine using the spark plug socket and tighten by hand,if possible,until the washer contacts the engine."crlf
            "Using your torque wrench, tighten the plug to what your car builder recommends."crlf
            "The torque spec can be found in your shop manual or online."crlf
            " "crlf
            "6. RECONNECT THE SPARK PLUG WIRE."crlf
            " "crlf
            "Listen for a “click” when installing the wire to let you know the wire is seated properly."crlf
            "If you have coil-on-plug, reattach the connectors keeping the coil in place."crlf
            "Re-connect the computer connection if you unhooked it."crlf
            "You can now proceed to the next plug."crlf
            " "crlf
)
)

(deffunction Changing-spark-plug-wires
()

(printout ig " "crlf
            "Changing plug wires is similar to changing the spark plugs—the less accessible the wires are, the more difficult the job will be."crlf
            "Sometimes the wires are in a place you just can’t access."crlf
            "Cars with coil-on-plug (COP) technology will not have wires, but an individual coil for each spark plug."crlf
            "If the coil fails, it can be changed."crlf
            " "crlf
            "WHAT YOU NEED:"crlf
            " "crlf
            "New spark plug wires specific to your car."crlf
            "Spark plug boot tool,optional."crlf
            "Spark plug grease,optional."crlf
            "Gloves and eye protection."crlf
            " "crlf
            "1. PREPARE TO CHANGE THE WIRES."crlf
            " "crlf
            "Wait until the engine is cold."crlf
            "Before you start tearing off plug wires, take a photo of how things are routed on the engine for future reference."crlf
            " "crlf
            "2. CHECK FOR ERROR CODES."crlf
            " "crlf
            "Use a code reader to check for engine misfire codes."crlf
            "Note if any cylinders are misfiring and then clear the misfire codes from the reader."crlf
            " "crlf
            "3. PULL THE PLUG WIRE."crlf
            " "crlf
            "You can start at the spark plug or coil end, but pull the plug wire and start removing it from any straps that are holding the wires together."crlf
            "Always pull one wire at a time to avoid installing the wire on the wrong plug."crlf
            "This also allows you to test after each wire if you wish to see if the wire was installed properly."crlf
            " "crlf
            "4. INSPECT THE WIRE."crlf
            " "crlf
            "Look for corrosion on the contact ends, brittle points, cuts, rubs, or abrasions that could cause sparking."crlf
            "If you find a worn spot, check the point where it was rubbing and look for evidence of arcing, such as black marks on the metal."crlf
            "Try to route the wire differently to avoid contact with metal or heat sources."crlf
            " "crlf
            "5. APPLY GREASE TO THE PLUG ENDS."crlf
            " "crlf
            "Applying dielectric grease to the inside of the spark plug boot prevents the boot from sticking to the plug and keeps water out of the connection."crlf
            " "crlf
            "6. INSTALL THE NEW WIRE."crlf
            " "crlf
            "Starting at either end, install the new plug wire."crlf
            "When installing the coil end, make sure it snaps in place and if your wire has a locking device, make sure it locks closed."crlf
            "On the spark plug end, listen for it or feel it click in place over the spark plug."crlf
            "Once you have the wire in place, you can move on to the next wire until all wires are exchanged."crlf
            " "crlf
            "7. RECHECK YOUR COMPUTER CODES."crlf
            " "crlf
            "Once you have all the wires changed, start the engine and let it run for a while."crlf
            "Recheck your engine computer codes."crlf
            "If you have a plug wire not making good contact, your engine may post an error code."crlf
            "If you are getting error codes and you know your plugs and wires are seated properly, you may have another problem in your ignition system."crlf
            " "crlf
            "   COIL-ON-PLUG SYSTEMS."crlf
            " "crlf
            "Changing the coils in a coil-on-plug system is similar to changing regular spark plug wires."crlf
            "Inspect the insulator, looking for damage and corrosion."crlf
            "Since the connection to the spark plug,a small wire or an insulator,is usually connected permanently to the coil, if you find damage you will need to change out the whole coil."crlf
            " "crlf
)
)

(deffunction SparkFail ;Symptoms of Bad or Failing Spark Plugs

()

(printout ig 
            "Good spark plugs will burn fuel efficiently, while bad or failing spark plugs can cause the motor not to start at all."crlf
            "Spark plugs are similar to motor oil, fuel filters, and air filters in that they require routine service and maintenance to keep your engine running strong."crlf
            " "crlf

            "IF SLUGGISH OR IRREGULAR ACCELERATION:"crlf
            "  The most common cause of poor acceleration in most vehicles is a problem in the ignition system."crlf
            "  Today's modern engines have multiple sensors that tell the onboard computer and ignition system when to send electric pulses to fire the spark plug, so the issue may be with a faulty sensor."crlf
            "  However, sometimes the issue is as simple as a worn-out spark plug."crlf
            "  A spark plug is composed of materials that work together to produce a spark hot enough to ignite the air-fuel mixture."crlf
            "  When these materials wear out, the effectiveness of the spark plug is reduced, which can significantly reduce the acceleration of the vehicle."crlf
            "  If you notice that your car is running sluggishly or does not accelerate as quickly as it used to, it may be attributed to a faulty spark plug that needs to be replaced."crlf
            "  HOWEVER,you should contact a mechanic to inspect this issue as it could be caused by multiple other factors including bad fuel filters, dirty or clogged fuel injector, or issues with oxygen sensors."crlf
            " "crlf
            "  You may notice the engine hesitating while accelerating."crlf
            "  In this case, the engine is not responding correctly to the driver."crlf
            "  It may suddenly surge in power, then slow down."crlf
            "  The engine is sucking in more air than it should be in its combustion process, causing the delay in power delivery."crlf
            "  The combined hesitation and surging could indicate a spark plug problem."crlf
            " "crlf
            
            "IF INCREASED FUEL CONSUMPTION:"crlf
            "  A fully-functioning spark plug helps burn fuel efficiently in the combustion cycle."crlf
            "  When this occurs, your car can achieve better-than-average fuel economy."crlf
            "  When the plug is not working optimally, it is frequently because the gap between the spark plug electrodes is either too close or too far apart."crlf
            "  In fact, many mechanics will take out spark plugs, examine them, and adjust the gap to factory settings as opposed to replacing the spark plug entirely."crlf
            "  If your vehicle has an increase in fuel consumption, it very well could be attributed to a worn out spark plug."crlf
            " "crlf
            
            "IF ROUGH IDLE:"crlf
            "  A bad spark plug may cause your engine to sound rough while idling."crlf
            "  The vehicle-encompassing, jittery sound will also cause your vehicle to vibrate."crlf
            "  It can indicate a spark plug problem in which a cylinder misfires only while idle."crlf
            " "crlf
            
            "IF STARTING HARD:"crlf
            "  If you have trouble starting your vehicle, it could be a sign your spark plugs are worn."crlf
            "  At the first sign of problems starting your vehicle, it's a good idea to contact a certified mechanic to take a look at the cause."crlf
            " "crlf
            
            "IF ENGINE-MISFIRE YES:"crlf
            "  If the engine misfires, it's typically due to an issue in the ignition system."crlf
            "  In modern cars, it's usually due to a sensor malfunction."crlf
            "  However, it may also be caused by a spark plug wire or the tip of the spark plug that connects to the wire being damaged."crlf
            "  An engine misfire can be noticed by intermittent stumbling or sputtering sounds from the engine."crlf
            "  If the engine is allowed to keep misfiring, exhaust emissions will increase, engine power will decrease, and fuel economy will drop."crlf
            " "crlf
            "Regardless of what the symptom might be, you might end up needing new spark plugs when yours eventually wear out."crlf
            "Being proactive about spark plug maintenance can extend the life of your engine by hundreds of thousands of km."crlf
)
)



(defrule SparkPlug


 (Plug  (acceleration sluggish|irregular)  (fuel-consumption increased) (idle rough) (engine-misfire YES))


=>

(SparkFail)

)


