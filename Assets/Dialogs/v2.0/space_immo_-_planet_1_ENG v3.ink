EXTERNAL loadQuestLevel1()
EXTERNAL playVoiceAlien1()
EXTERNAL gameOver()

* [Oh, in the name of Neptune...] 
**[What a hangover... My head is ringing. I hope I'll have some clients today.]
***[I'm so sick of dealing with local stellar architecture students...]
****[They are as broke as video games creators.] 
*****[They couldn't find a place to settle, and they make me loose time and money.]
******[Plus I can't even rip them off : they have no money.] -->planet1

====planet1====

//Image du client avec son morphotype et ses caractéristiques (eau, feu, taille, poids, densité de sa matière)

[Ah! My first client of this stellar day! I can feel a right sucker when I see one...]
* [Hi, how can I help you?!] -->reponse1
* [Hi, sucker!]-->mauvaiserponse1
* [Don't say anything, I have just the right place for you!] 
My dog can make you some room in his kennel, it is so cozy in there if you ignore the human bones here and there! -->mauvaiserponse1

==reponse1==
{playVoiceAlien1()}
Gutorbz : I’m looking for a planet I can settle in with my 6 billion larvae. -->question1
//attendu : elle est grande

==question1==

*[Very well, do you have a particular location in mind?]
    Gutorbz : If that is not too much to ask, I wish to live as close as possible to the northern boundary of the Milky Way. It’s o beautiful there.

    
** [Understood. What type of planet are you looking for?]
{playVoiceAlien1()}
 Gutorbz : Very humid, with a lot of trees and flowers, it's so romantic, reminds me of my human colonization... Oh, and as dark as possible. Oh, and of course, not hotter than 30 degrees. My larvae need to be nice and cozy!
     //attendu : marais x1, fleurs x2 ou 3, arbres x2
     
*** [And your price?]    
Gutorbz : I’d rather not exceed 5000 stellar credits per solaryear.

****[Alright, let’s see what we have here…]

***** [In the Nortern Boundary neighborhood, for 5000 credits.]
    Gutorbz : Is it dark? And what about the view?

******[Unobstructed view on the Northern Boundary of the Milky Way.]
    {playVoiceAlien1()}
    I like to watch the sun while having human coffee.
    
******* I see. What is your favorite coffee?
    Gutorbz : I usually have the one with the grey-haired human, that human females fancy. 
    
********So you're having Nezprezzo?
   Gutorbz : No, I squeeze George Cloozey directly. They made clones of him, you see, and now with its new DNA you can have coffee right out of his body. Guess which hole it's coming out from!
    
*********Ahum, and let's go back to this planet.
   Gutorbz : I need mountains. I do love trekking on my George Cloozey's back!
    //attendu : montagnex1
    
**********I can find you a bumpy planet.
    Gutorbz : Perfect, and if you have a lot of flowers there, but all dead, you know, maybe I can buy it for... cash? 
    //attendu : arbres morts x1, fleurs x2
        
*********** Well, as it happens, I know people at the Planet Tax Authority, it can always be fixed ;)
    Klupton : I know, I had a visit from a controller on my current planet. He didn't last a lot, hahaha!
    
************ Will that be all in your Golden Menu? Oops, sorry, my former job got to my blood. 
    Gutorbz : Ah! Since we are on the food topic, I'd like to have some good lava on my land. Good stuff, huh! Not the bad one, half azote, half ashes.
    //attendu : planet avec volcan/lave

************[Duly noted, that will be comprised in the service charges.]
    Gutorbz :Wery well then, how much for this planet?
    
************* [4500 credits + 1500 credits of de-gassing fees, for the larvae.]
    Gutorbz :So, the rent is 6000 credits…
    
************** [Yes, it is a bit over your price limit but the view is amazing, very dark.]
***************[Almost no opposite planets. Shall I prepare it for you?]
    Gutorbz : OK, let’s go for it. 

**************** You won’t be sorry!
{loadQuestLevel1()}
-->quest






==mauvaiserponse1==
Oh, the sucker left...-->Badend

==mauvaiserponse2==
Hey! Come back, sucker friend!!
-->end

==quest==
-->DONE

==Badend==
*After loosing track of your first and last client of this solar year, you throw yourself in a black hole, totally drunk.
-->end

==end==
{gameOver()}
-->DONE
