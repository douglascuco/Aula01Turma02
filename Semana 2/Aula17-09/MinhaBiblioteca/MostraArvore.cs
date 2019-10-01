using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostraArvore
    {
        /// <summary>
        /// Método para mostrar uma arvore na tela
        /// </summary>
        public void CriarArv()
        {
            while (true)
            {
                ListaDeFrames();
            }

        }

        /// <summary>
        /// Metodo que mostra na tela uma seguencia determinada de frames de uma arvore
        /// </summary>
        private static void ListaDeFrames()
        {
            var listaFrames = new List<string>
            {
                @"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                  `..`                                          
                                 -+ss++:/:/+--/:. ..                            
                               `-:/ohyoososs/oys+:/++`                          
                             `-ososoyyosyhyooys:+ss/:`                          
                           `-/+oo/-+/ysooysso+:/sssso/`                         
                         `//-/:/: ...oyosssyso/++o://:                          
                         `---:-//.   ++y:`.o://++::o/`                          
                         `/:/+o:-.---o/o  +`-:.     `                           
                           .``.       /s-/+-`                                   
                                       oy.                                      
                                       :o                                       
                                       ++                                       
                        ```````````....ss.........```````                       
                        ````````````..........``````````                        
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                  `-..                                          
                                 :osso+/+:/o-:+/- `-`                           
                              `.:/+shyosssss+syso:/+o.                          
                           ```:osoooyyssyhyo+ss//ss+:.                          
                          ``-//oo/-+:ysoosssoo:+sssso/`                         
                         `/+:/:/: ...oyosooyyo/+++///:`                         
                         `---:://.   ++y:`.o///+o:/s/`                          
                         `/:/+o:-.---+++  +`-:.     ``                          
                          `.```       /y-/+-`                                   
                                       +y.                                      
                                       :o                                       
                                       o+                                       
                        ```````````....ss..........``````                       
                        ````````````..........``````````                        
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                  ./..  ` ````                                  
                                 :osyoooo:oo-/oo- `-`                           
                              `./++sysssysysosyso-++s/                          
                           ```:ssoooyyssyyyo+so:/sso:-                          
                          ..-//so/:+/ss/sysyso/+sysso+.                         
                         ./+://:: ...oyososyso:+++:/::`                         
                         .:--::+/-`  +oy:`-+::+/+:/o/.                          
                         `-:/+o:-`.--++o  o.::.     ``                          
                          `` ``       /y-//.                                    
                                       +y`                                      
                                       :o                                       
                                       oo                                       
                        ``````````.....ss..........```````                      
                       ```````````.............`````````                        
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                 `:/--````.`..                                  
                                `+syssos++oo-+ss: `:.                           
                              `:o+oysysyysyssyys+-o+s+`                         
                           ``./ssosoyysoyyyo+s+-/syo:-                          
                         `..-//so/:o/so/sysyoo++oyysos-                         
                         .:+///// `..oyos+oys+-o++//::`                         
                         -/::::++:`  +oy-`:/-/+:+-/s/.                          
                         ..::+o:.`.-:+oo  o.::`     .`                          
                             ``       :y-+/.                                    
                                       +y`                                      
                                       :o                                       
                                       oo                                       
                        ``````````.....ss..........```````                      
                       `````````...............`````````                        
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                   `                                            
                                 ./+--...`....``                                
                                .osyysss+ooo:+ss: `::.                          
                               +oooysysyhsyssyyo/-ooso`                         
                           `..+ssossyys+yyyooo+:+yys/-                          
                         `---:/ss/:o/so/sysyoso++yysos:                         
                         .///++:/ ..-syos+oyy/-oo+//::.                         
                        `-////:++:.  /oy-`//-/+:/-/s/.                          
                         `.-./o/. `-:/oo  s.:-`     ``                          
                             ``       :h:+:`                                    
                                       +y`                                      
                                       :o                                       
                                       oo                                       
                        `````````......ss..........```````                      
                       ````````.................`````````                       
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                   `                                            
                                 :++:-.--.----..                                
                               .-osyyssyooos/oyy: .:/.                          
                              .+o+oysyshhsysyyy+:+soss.                         
                           ``.ossosoyhs+syyoo++:+yyo/-`                         
                         `---//so::o/so/yysyoso++yysoy/`                        
                         -/+:+/:/ `..oyos+oyy/.oo+/--:.                         
                        `-/://:o+:.  /oy-./:-/+-/-/s/.                          
                         ..:-+o+. `-:/oo  s-:-`     ``                          
                             .`       :h:+:`                                    
                                       +y`                                      
                                       :o                                       
                                       oo                                       
                       ``````````......ss...........``````                      
                       ```````..................`````````                       
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                   `                                            
                                 /oo/:-::.::::--                                
                               -:osyyyyyosos+syy/`.:+-`                         
                              :+ooosoysyhyysyyyo:ssoos-                         
                           ``-sss+ooshy+syyoo++/oyyo/:`                         
                         `.-:/+so::o/so/yysyoyo//yssoy+`                        
                        `:/+:+/:: .`.oyos+oyy+.oo//--:.                         
                        .://:/:++:.  /oy-`+:-/+-/-/s/.                          
                         -.::+o+. `--/oo  s-:-      ``                          
                          `` .`       :h/+:`                                    
                                       +y`                                      
                                       :o                                       
                                       oo                                       
                       `````````.......ss...........``````                      
                      ```````...................`````````                       
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                  ``                                            
                                `+ss/::/:://///:`   `                           
                              `-/ssyyyyyssssosyy-`-/+:.                         
                             ./+oossssyhhyysyyy+/ssoos:                         
                            `/sso/ooshs+syyoo/++syys/:`                         
                         `.///ss/::o+yo+yysysyo//ysooy+.                        
                        .//-:/:+. ``-syso+oyy+.os//:.-.                         
                        .//+/////-`  +os.`o..++-:.:o+:                          
                        `/-//+oo-`.--/oo  s::.      ``                          
                         `.. :-       :h/+-                                     
                                       +y`                                      
                                       /o                                       
                                       oo                                       
                       `````````.......sy-..........```````                     
                      ``````....................`````````                       
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                 `..`                                           
                                -oss+/+//+++++o/`   .                           
                              .:osyyyyyyyssssyy+..:+o/.                         
                             :/+osyossyhhyyyyys/+ysoos-                         
                            `ssso/o+yhs+syyoo+o+yyyo:/.`                        
                         `:/:+so/:/ooy++yssyyy/:+ssssy+`                        
                        -/:.:-++  .`-sssoossy/-os///..`                         
                       `://+///::.   +os``o`.+/--`:++/                          
                        -/:++oso-.--:/oo `s::.       `                          
                         ...`/:`      :h/o-                                     
                                       +y                                       
                                       /o                                       
                                       oo                                       
                       `````````.......sy-..........```````                     
                     ``````.....................`````````                       
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                 `-.`  ```  ``                                  
                                /sss+/+/++oooso/   `-                           
                              -:ssyyyyyyysssyys:--:+s+-                         
                            `/++ssyossyhyhyysso/oyssoo-                         
                            -sso/+ooyysosyyooosoyyyo:+:.                        
                         .::/ss+/:++oh+oyssyyo:-+ssosy+`                        
                        --:-:-o/  . :ssyooyss-:ss///`.`                         
                       .:++++///:.   oos``o`.o/..`./++                          
                       `:+/+ooso-.--:/oo `y::`                                  
                        `-.-`++.      :h/o.                                     
                             `         +y                                       
                                       /o                                       
                                       oo                                       
                      ``````````.......sy-..........```````                     
                     `````......................`````````                      `
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                 .:-.  `````..                                  
                               `/syso++++ossoss/   `:`                          
                              -/ssyhsyyyysysyyo:::/+so:`                        
                            -/++ssysyyyhyhyyss+osyssoo/                         
                            +so/:/+oyysosyyssssoyyy+///:                        
                         .:-+ys+/:o+oy+oyysyy/::+ssooso`                        
                       `--::-:o:  .`:ssyooyss-:ss/++..`                         
                       ./+//o+//-`   soo``o`-+/`. ./++`                         
                       -:+/oo+s+-----/oo `y::`                                  
                        .---.+o:      :h+o.                                     
                             .         +y                                       
                                       /s                                       
                                       oo                                       
                      `````````........sy-..........```````                     
                    ``````.......................`````````                      
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                 -//- ``..`.:.``                                
                              `-+syyso++oosssss:    :.`                         
                              -+ssyhyyyhysyyyys-/+/+so:.                        
                            :/oossyshyyhyhyyss+ssyssos+                         
                           `oo/::/+shysosyyysssosyy+//+/`                       
                         .-.oys+::o/oyosyyyyy:::+ssooss.                        
                       `-///-+o. `.`:yysoosss-:ss:o+.-`                         
                       :/+//++//.   `s+o `o`:o/`. `:+o`                         
                       -/+/oo+s+:--:-/+o .y::`                                  
                       `-:-:-+o/      :h++`                                     
                          `  -`        +y                                       
                                       +s                                       
                                       oo                                       
                      `````````........sy-..........```````                     
                    `````........................`````````                      
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                `:+o:```.-.-:-``                                
                              `:ossyss++oossssy:   `::.                         
                              -ossyhyyyhysyyyyy:/o/+ss/.                        
                           `:+sosshyhsyhyhyyso+sshssooo`                        
                           -oo::-/+shssoyyyysososyyo//+/.                       
                         .:-oys/::o/ossssyyyy-::/so+ssy-`                       
                       .:///-/o` ```:yyy+ssso-:ss:o+--`                         
                      `-++//++//.`  `y+o `o./o:`` `:+o.                         
                      `:+++ssos+-----++o .y::`                                  
                       `:----+o:      /h++`                                     
                            `-`        +y                                       
                                       +s                                       
                                       oo                                       
                     ``````````........yy-..........```````                     
                   ``````........................``````````                     
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                   `                                            
                                ./os:``.::-//-..                                
                              .+osyyssoossyyyyy- ` `//.                         
                            ` :ssyyhyyyhyyyyyyy+/o++ss/.                        
                           `/osoyshhhsyhyhyhss+syhysoos.                        
                           :oo/--/osysssyyyys+oooyho++o+.                       
                        .:/:oys/::o:sssssysyy.-/+so/oss-`                       
                       -/+/:-/o` ```:yyy+ssso::os:o+..`                         
                      -/o+/+o+//-```.y/o `o.:o:`` `:+o.                         
                      `:+/+soos+..---+/s .y::`                                  
                        -.-`:++.      /ho+`                                     
                            ``         +y                                       
                                       +s                                       
                                       oo                                       
                     `````````.........yy-..........```````                     
                   ``````........................``````````                     
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                  `.                                            
                               `:+so/`-:///++:.`                                
                             `-oosyhysosssyyyyy:````//.                         
                            -`/ssyhhyyyhyyyyyss+/o++ss/.                        
                           `+ssssshhysyhyhhhss/syhysooo-                        
                         ``-+s+:-/+syyosyyyys/oooyhoo+s+-                       
                        :++-+ss/::o:ssossysss.-/ooo/+ss-                        
                      .:/+:+:/o. ```:hyyosyss:/os:o+.``                         
                      -/o/++o+/+:-..-h/o`.o.:o:`` `:+o.                         
                      `-+:+ooos+``...++s .y::                                   
                        .-.`//-`      /ho+`                                     
                            `          +y                                       
                                       +s                                       
                                       os                                       
                     `````````........-yy--.........````````                    
                   ``````........................``````````                     
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                ``:.`  ..` `.                                   
                              `-osyo+-/++oos++/.     `                          
                             .oosyhyssysssyyyyy/...-+o-                         
                            :/oyyyhhyyhhsyyyyoss/so+ys+:                        
                           -osssyyhhyyyyyyhhso/syhyyooy/`                       
                        `-++oys+-/+oysosyyyyy+osoyhsooyy/                       
                      `:++++:+y:::+/sysssssos-`+oo+-:++-                        
                      -/+o/+o/:: ` `:hyyoysss//+s/oo-.`                         
                      ::+/oso/o+:--::h-o.-o`:+-`` `-++:                         
                      `.:-/-+oo:    `/+s -y:-                                   
                        ``  :.`       /hs+                                      
                                       +y                                       
                                       +s                                       
                                       os                                       
                     ```````..........-yy----........```````                    
                  ```````........................`````````                      
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                ../-` `-.```.                                   
                              .:ssyo+:+/+oosoo+-     `                          
                            `:oosyyysyyssoyyyyyo.-.-+o:                         
                            :+syyyhhyyhhyyyyyosy+oooyy+/                        
                          .:osssyyhhhyyyyyyhso+oyhyysoys.                       
                       `-/+osyyo-/o+yyooyyyyy++soyhyosys/                       
                      -:++/+//s::///syysssooy-`+os+-:/+:                        
                      :+o++oo+:: ` .:hysoyyss+/+s/os:-`                         
                      --//ssoooo::-:/d-+..s.:+-``  -+//                         
                       .---.oo+-    `/os -y:-                                   
                           `.`        :ds+                                      
                                       +y                                       
                                       +s                                       
                                       ss                                       
                     ```````..........-yy----.........``````                    
                  ```````........................`````````                      
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                .:+:. -:.`....                                  
                             `-+syyo+/+/ooossso/     `                          
                            `/ossyyysyyyooyyyyys-:-:+s/                         
                            -+syyyhhyyhhyysyhyoyoosoyy++`                       
                         `:/osssyyyhyysyyyyhso+oyhyhsshy/                       
                       -/ooooyhs-/o/ysooyysyyo+ooyhysshs/`                      
                      ::/+/+/:o:-//:shyyssooy:`+oo+--:+:                        
                      /+o/ooo/// ` .-hys+yysso++s/+s+:.                         
                      .:::oooooo::::/d-+`.s.:+-`   .///                         
                       `.-`.o+/.     /os -y:-                                   
                            `         :dy/                                      
                                       +h                                       
                                       +s                                       
                                       ss                                       
                     ```````..........-yy----.........```````                   
                  ```````........................``````````                     
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                -/o:.`:/..---.`                                 
                             .:osyyo++++ssosssso`    ``                         
                            .oosyhyyyyyhsoysyyyy/:::+s/                         
                            -+syyhhyyyhhyyyyhyssssssyyoo.                       
                         ./+osyyyysyyysyyyyhyo/oshyhyshyo`                      
                      .:++ososyy:/s+yssoyysyyo+ooyhhssyy/                       
                      :/++/++:o:./::shyysssoy:`+ss+:.-/:                        
                      :/+/oos//+`  .-hys/yhssoo+o/+yo/:                         
                      `:-:++ooso::::/d.+``s.:+-.   `:::`                        
                        ..`.+::`     :ss :s:.                                   
                                      :dy/                                      
                                       +y                                       
                                       +s                                       
                                       ss                                       
                    ````````..........-yy----.........```````                   
                  ```````.........................`````````                     
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                 ``    `                                        
                               `/+o/``//..:::-`                                 
                            `-+syyyoo+o+sssssyys-    ``                         
                            -ssyyhyyyyyhyoysyyyy+/:/+s+`                        
                            -+syyhhhyyhhyyyhhyssysssyyys:                       
                        `-+oosyyyysyhysyyyyhys/oshhhyoyhs.                      
                     `::o++sssyy:/s+yssoyssyys/ooyhhysyy/`                      
                      :++o/+o:+:`/::shyysosoy/`+ss+:.-+:                        
                      ::++oss//+`  ..hys/yhssso+o//ss//                         
                      `:-:++oos+-:::/d.o `s.:+..   `:::`                        
                        .` ./--`     :ss :s:.                                   
                                      :dy/                                      
                                       /y                                       
                                       +s                                       
                                       ss                                       
                    `````````.........-yy-----........```````                   
                  ```````.........................`````````                     
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                 ``   ``                                        
                               .ooo/`.+:--///:-`                                
                            `:osyyyso+ooosyssyys/    ``                         
                            :ssyyhhyyyyhyoysyyyho///+so`                        
                          ` -+syyhhyyyyhyyhhhyysyyssyyys/                       
                       `.:ooosysyhsshysyyyyhyy/+shhhyoyhs-                      
                     `/:o++sooys//soyssoysoyss/ooyhhhsyso.                      
                      :+oo/+o/+:`/::shyyssssy/`+ss+/-:+:`                       
                      ::++sso/++.  `.hss/shssso+o//ss//`                        
                      `/-:/+oos+-:::/h.o `s.:+.`   `-:-`                        
                        `` .:--`     -sy :s:.                                   
                                      -dh/                                      
                                       /y                                       
                                       +s                                       
                                       ss                                       
                    `````````.........-yy-----.........```````                  
                  ```````.........................``````````                    
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                `-.`  `.                                        
                              `:sso+..+:-:////:.                                
                            .+ssyyyysosooyssyyyy+`   ..                         
                            /ssyhhhyyyhhysysyyyhs++++ss.                        
                          ``:+syyhhhyyshyhhhhyyssyysyyyy+                       
                       .-+ossyhsyhsshysyyyyhyy++yyhyysyhs/                      
                     `+:+++oooyso/yoysssyyoyso+ooyhhysyys:                      
                      :+oo/+o+/: -::shsyssssy+.+ss+/-:o:`                       
                      /-/+soo/o+-` `.yso:shssss+o//sso+.                        
                      `/--//oos+.-::/h.o `s.:+.`    ---.                        
                        `  .:..`     -yy /s:.                                   
                                      -hh:                                      
                                       /h                                       
                                       +s                                       
                                       ss                                       
                    ````````..........-yh------........```````                  
                  ```````.........................``````````                    
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                                .:-.  .-                                        
                              ./syo+--++:://///-                                
                            .+ssyyhysoysssssyyyys:`` --                         
                            +ssyhhhyyhhyysyyyyyhyso+osy/`                       
                          ../oyyyhdyyyshhhhhhyyssyhsyyhys`                      
                      `-:osssyhsyhyyhysyyyyyyyo+yyhyysshy+`                     
                     `+:++/oooyss+yoyyosyyoyyo/++yhhhsyys/`                     
                     `/ooo+os+:: --:shsysssyys.+ss++-:o/.                       
                      /:/+soo/oo-` `.yso-oyysss+++:oyso-                        
                       :--:/oos+`-::/h-o  s./+``    .-``                        
                           .-.``     -yy`/s:`                                   
                                      -hh:                                      
                                       /y                                       
                                       +s                                       
                                       ss                                       
                    ````````..........-yh------........```````                  
                  ``````...........................`````````                    
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                               `-/:. `.:`                                       
                             `-+syo+-:+o//++/++/.                               
                            -osyyyhyssysssssyyyhy+.` -:`                        
                           `+oyhhhhyyhhyyyyyyyyhyysoosyo.                       
                         .--/syyyhhyyyoyhhhhhyyssyhyyyhhy.                      
                     `.:+ssssyhyyhyyhysyyyyyyys+yyhhysohyo.                     
                     `/:++/+s+yss/yosyssyssyyo//+shhhyyyso`                     
                     `/+oo+oo+:/ ---sdoyyssyyy:+ss+o:/s+.                       
                      :::/soo/so:. `.yso.+sssss+/+-+yss+                        
                       ---.:oooo`.::/h:+  s.//``    `. `                        
                           ..```     -yy`/o:`                                   
                                      -hh:                                      
                                       /y                                       
                                       +s                                       
                                       ss                                       
                    ````````..........-yh-----.........```````                  
                  ``````...............--..........`````````                    
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                                                                
                               .:o/- `-:``                                      
                             .:osyso::+o+/+++ooo-`                              
                            :syyyyhysyyysyssyyyhyo-. -/-                        
                           `/oyhhhhyhhhyyyyyyyyyysys+sys/                       
                         -::/syyyhdyyyoshhyhhyyssyhyyyhhh:                      
                     `::osssyyhyhyyyhyyysyyyyysoyyhhysoyyo-                     
                      :/+o+/s/yyo/yosyssyssyyo/:/shhhyyyyo.                     
                     `//oo+oo+:/ -.-sdoyysyyyy/oss+s//s+-                       
                     `-/-/sss+ss/-``.yso`/oosss///./osoo                        
                       .--`-oooo `::/h:+  s.+/``     `                          
                           `.```     .yy`+o:`                                   
                                      -hh:                                      
                                       /h                                       
                                       +s                                       
                                       ss                                       
                    ````````..........-yh-----.........````````                 
                 ```````.............-.---.........``````````                   
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                 `                                              
                               .+o+/ `-/.`   `                                  
                             -/syhso/:+so/ooosss/.                              
                            :syyhyhysyyysyysyyyhhs:-`:/:                        
                           `:+yyhdhyhhhyyyyyyyyyysys+syy+`                      
                        `:/+/syyyydyyyoyhhyhhyhssyhyyhhhh/                      
                     `/:oosyyyhyhyyyhyyyyyyyysoohhhdyooyyo/                     
                     `:+oo++o/yyo/yoyhsssssyho/::syhhyyyys.                     
                     `/:+ooos+:/ -.-shoyysyyyy/+ss+so+so:                       
                     `-+-/sos+ss/:```yso`/oosss/:/.:+soo`                       
                       .-. -oooo `-:/h:+  s-+/``                                
                           ..```     .yy`+o-`                                   
                                      .hh:                                      
                                       /h                                       
                                       +s                                       
                                       ss                                       
                    ````````..........-yh------........````````                 
                 ```````...........-.-----.........``````````                   
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                `.``                                            
                               .+so/``:/:. ``.``                                
                             :osyyys+/+so+ossssso-                              
                            :syyhhhysyyysyysyhyhys/:`-+/`                       
                           `:oyyhdhyhhhyyyyyyyysysyy+oyyo.                      
                        ./+o+syyyydyyyoyhyyhhyysyyhyhhhhho                      
                     `//oossyyhhhyyyhyyyyyyyysooyhhdysohyo+                     
                     `/+ssooo/sy+/ysyhsssssyhs/:/oyhhyyhys-                     
                     ./:+o+os+// -.-shoyysyyyy++ysoss/ss-                       
                     `.+-:sososs/:```ys+`:o+sss/:/.-+soo.                       
                       `-. -oooo``-:/h:+  s-+/``     `                          
                           .-``.     -yy`++-`                                   
                                      .hd-                                      
                                       /h                                       
                                       +y                                       
                                       ss                                       
                    `````````.........-yh-----..........```````                 
                 ```````..........--------..........`````````                   
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                `:..`                                           
                              `-oys+` :+/-``..`.                                
                             /ssyyho+/+soosyssyys:`                             
                            :sshhhyssyyhsyysyhyhhy+:`:+/.                       
                           `-oyyhdhyhhhhyyysyyysyyyyosyys:                      
                      ``:oososyyyhdyyh+yhyhhhyysyyhhhhhhhy-                     
                     `//+osyyyhhyyssdyyyyyyyysosyyydhs+yy++`                    
                     .++ssooo/sy+/yoyhsysyyyhs/::oyhyhhhys-                     
                     ./:+oooo+// -`-shsyyssyyh+oyyosy/ss:                       
                     `.+-/s+soss/:.``hso`:++sss/:/`./soo-                       
                       `.` :ooso  .:/h:o  s-+/``                                
                           ..``.     -yh`++-`                                   
                                      .hd-                                      
                                       /h                                       
                                       +y                                       
                                       sy                                       
                   `````````..........-yh-----..........```````                 
                 ```````........-----------.........``````````                  
",@"                                                                                
                                                                                
                                                                                
                                                                                
                                `/--.                                           
                             `.:oys+` :oo:-.--..`                               
                            `+ssyyhso++soooyssyys/`                             
                           `/syhhhyssyyhsyysyhyhhy+/`:++-                       
                          ``:syyhdhhyhhhhyysyyysysyyssyyy+`                     
                      ../sssssyyyhdyyh+yhyhhhyysyhhhhhhhhy+                     
                     `//+osyyyhhyyssdyyyyyhyysssyyydhooyy//`                    
                     -+osoooo+sy++yohhyyssyyhy::/oyhhyyhss:`                    
                     .//+ooos+// - -shyyyysyyy/+syosy+sy:                       
                      `+-/o+ooss/:.``hs+`:++sss/::`./sos/                       
                           /oos+  .-/h-o  s:+/``                                
                           .. ..     -yh`++-                                    
                                      .hd-                                      
                                       /h                                       
                                       +y                                       
                                       sy                                       
                   `````````..........-yh-----..........```````                 
                 ```````.......------------.........``````````                  
",@"                                                                                
                                                                                
                                                                                                                                                                
                                .+::.  `                                        
                             .-/oyy+` /oo/::::--`                               
                            `+ssyhhss++ssssyssyyy/`                             
                           `/syhhdysyhyhyyyyyhyhhy+/`:oo-                       
                         .../syyhdhhhhhhhhyyyhyoyyyyyyyhy+.                     
                     `:-+ssysyyyyhdyyhoyyyhhhyysyhhhdhhhdho`                    
                     `//ossysyhhyyssdhyyyyhyysosssydhoosy/-`                    
                     -oosoo+o+oy++sohyyyyysyhy-/:+shyyyhss/.                    
                     .//+osss++/ - :shyyyssyyy/oyy+ssoss/`                      
                      `/-:o+ooss/:-.`hso`/++sss/-:`./ysoo`                      
                           +o+s+  .-/h:o  s:+/`                                 
                           .. ..     -yh.o+-                                    
                                      .hd-                                      
                                       /h                                       
                                       +y                                       
                                       sy                                       
                   `````````.........--yh-------........```````                 
                ````````......--------------.........`````````                  
",@"                                                                                
                                                                                
                                                                                
                                 `                                              
                                -o//.  ``                                       
                             -/+syy+.`/ss++///::.                               
                            .+syyhhys+ososossyyyy/`                             
                           `+yyhddysyhyhyyyyyyyhhh++.:oo:                       
                        `--.+syshdhhhhddhhyyhhssyyhyhyyyyo-                     
                      //ossysyyyyhdyyhsyyyhhhyysyhhhdhhhdhs.                    
                     `:/ossysyydhysydhyyyyhyyyossshdhsosy-.`                    
                     -++sooooooyo+sohyyyyysyys-/:+syhsyysso.                    
                     .//+oyss+++`. :shyyyssyyy+oyy+ssoso/`                      
                      `/::/+ooso//:..hso`+oooss/-:../ysss.                      
                           +o+s/  `-/h:o  s:+:       `                          
                           `` ``     -hh.o+.                                    
                                      .hd-                                      
                                       /h                                       
                                       +y                                       
                                       yy                                       
                   `````````.........--yh-------........````````                
                ```````.......--------------.........`````````                  
",@"                                                                                
                                                                                
                                                                                
                                ``                                              
                                :s+/-  ..                                       
                             :/osyy+-`/ssooo++//.                               
                            -osyhhhysoossysssyyys/``                            
                           `oyyhhdyyyhyhysyyyyyhhho+-:oo/`                      
                       `.::-+sysydhhhhdddhyhhhysysyhhyhhhs:                     
                      /osssysyyyyhhyhhsyyyhhhyhoyhhhdhhhdhy-                    
                     `/++ssyohydhhsyhhsysyyyhysysshdhsoss:.                     
                     .//oo+soooso+s+hyyyyyyyys-/:osyhssysys-                    
                     .:+:oyss+++`. -shyyyssyyyoosy+oooss:`                      
                      `::::++oss//:-.hoo.+sooss/--.-+yyyy:                      
                           /o/o+  `./h:o  s:+:       ``                         
                           `   `     -hh.o/.                                    
                                      .hd-                                      
                                       /h                                       
                                       +y                                       
                                       yy                                       
                   `````````.........--yh-------.........```````                
                ```````.......--------------.........`````````                  
",@"                                                                                
                                                                                
                                                                                
                                `.`                                             
                               `/so+: `.-``                                     
                             :+ssyy+-`/ssoss+++/.                               
                            -osyhhhyysossyssyhyhs/``  `                         
                           .oyyhhdyyhhhhysysyyyhhhs+-:sso`                      
                      `-.++:osyyydhhyhhdddyhhhssyyhhhyhhhs:                     
                      :oossysyyyyhdyhhssyhhhhyhoyhhhdhhhdhh:                    
                     `+oosyyshydhhsydhoyyyyyhysysshhhsoso/``                    
                     .//oo+sososooo+hyyyyyyyhs./:osyhysysys:                    
                     .:+:+yss+o+`. -shsyysssysooyy+oooss:`                      
                      `---:+ooso:/:-.hoo.+s++so/-:.-+yyyy:                      
                           ++:++   .:h:o  s:+:       ```                        
                                     -yh.o/.                                    
                                      .hd-                                      
                                       /h                                       
                                       +y                                       
                                       yy`                                      
                   `````````.........--yh-------.........```````                
                ```````.......--------------.........`````````                  
",@"                                                                                
                                                                                
                                                                                
                                .-.`                                            
                               ./soo: `-:`.                                     
                             :ossyyo:.:osssyooo+-                               
                            :ssyhdhyysossyssyhyhy/..  `                         
                           .oyshhdyyhhhhysysyyyhhhyo::sys`                      
                      ./-oo+osyyydhhyhhhddhhhhssyyhhhhhhhy/`                    
                      -+sysysyyyhhhyhhysyhhdhyhsyhhhdhhdddh+                    
                     .+sssyysyyhhysyhhoyyyyhhysysohhdyoso-`                     
                     `//+oosssosooo+hyyhyyyyys-/:osyyssysys:                    
                     `-+-+yss+oo.- -shsyysssssooyy++ooss-                       
                       ---./ooso:/::-hoo-+y++so/.:.:oyssh/                      
                           //-++   `:h:o  y:+:       -..`                       
                                     -yh-s/.                                    
                                      .hd-                                      
                                       /h                                       
                                       +y                                       
                                       yy                                       
                   `````````.........--yh-------.........```````                
                ```````.......--------------.........``````````                 
",@"                                                                                
                                                                                
                                                                                
                                :/-..                                           
                             ..-/sss: .:/--.``                                  
                             -ossyhs+:-osssysoss-                               
                           `/yyyhdhyyysssyyyyhyhy+:-` .``                       
                         ``-syyyydyyhhhhysyyyyyhhhyy++syy:                      
                      .oosoosyyyyddhyhhhddhhhhyyyhhhhhhhhho.                    
                      :/oysyyhhyhhhhhhysshhdhyyyhhdddhydddy+                    
                     -+ssyhoosyhhysydhoyyyyyhysy++hddyoso:``                    
                     ./+osyyyysy+s++hyyhyyyyyo-+/ossssshoys+.                   
                      .+:+yss+so-- :ohsyysssssooyy//o:so.                       
                       .`../oss+-//::hoo-+yoooo/.:./yysos:                      
                          `/:-//   `:h/o  y:+:      `/::-`                      
                                     -yh-s/`                                    
                                      .hd.                                      
                                       /h                                       
                                       oy                                       
                                       yy                                       
                   `````````........---yh-------.........````````               
                ```````.......--------------.........``````````                 
",@"
                                                                                                                                                                                                                                               
                                //--.                                           
                             .--+yss- .//:-.```                                 
                            `-ossyhso/:ssyyyysss-                               
                           .+yyyhdhsyyssyyysyhyyy+/:` --.                       
                       ``.`:syyyyhyyhhhdyyysyyyhyhhyoosyh+`                     
                      -ssssosyyyyddhyhhhhdhhhhyhhhdhdhhhhhs-                    
                     `:+oysyyyhhhhhhhhysshhdhyyhyhdddhydddy+                    
                     -ossyyoosyhyssyhh+yyyyyhhos++hdhyoso/`.                    
                     -/+osyysysy+s/+hyyhyyyyys-+/+sosyshsss+-                   
                      .+-+sss+so:- :ohsyyssssssoyy//+/so`                       
                       ` `.+oss+-///:ho+-+y+oso/.:./yysos/                      
                          `/--/:    :h/o  y/+-      `/:::`                      
                                     -yd:s:`                                    
                                      .hd.                                      
                                       /h                                       
                                       oy                                       
                                      `yy                                       
                   `````````........---yh-------..........```````               
                ```````.......--------------.........``````````                 
",@"                                                                                
                                                                                                                                                               
                                //::-                                           
                             -::oyys- -++/:-.`.`                                
                            `:osyyhyo/:ssyyyysyy-                               
                           .+yyyhdhsyysyyhysyhyyy+/:``---                       
                       `..`/ssyyyhhyhhhhyyyyyyyhyhhysssyhs`                     
                      :ssyyssyyyyddhyhhhhdhhhhhhhhdddddhdhy:`                   
                     `/+sysyyhhhhhhhhhhsyyydhsyhyhdddhydddyo`                   
                     -+ssyy+osyhyssyhhoyyyyyhyoo++hdhyoys:.-                    
                     -/+osyysyyy/s/+hhyyyyyyyo-+/+sssyshyss+:                   
                      .+:+sssoso/- :syyyyssysssoyy+/o:os.                       
                       ` `-ooss+-////ho+-+s+oso/.:.:yyo+s/                      
                          ./--/:    :h/o `y/+-      ./:::`                      
                                     -yd:s:`                                    
                                      .hd.                                      
                                       /h                                       
                                       oy                                       
                                      `yy                                       
                  `````````.........--:yh-------..........```````               
               ````````......---------------..........`````````                 
",@"                                                                                
                                                                                
                                `                                               
                                ++//:                                           
                             -//oyys: -+o//:-..`                                
                            `:osyhhso+:ssyyyyyyy-                               
                           -oyyyhdhyyyyyyhyyyhyyy+o+.`::-`                      
                       .--.+ysyyydhhhhhhhyyyyyyhydhyssyyhs.                     
                      :ssyysyyyyyddhyhhhhdhhhhhyhhdddddhdhy/`                   
                     .++syyyyhhhhhhhhhhsyyhdhyyyyhdhdhydddso`                   
                     -+osyy+ssyhyosyhhoyyyyyhy+o/+hhdyoyo/-:                    
                     -/+osyysyyy/s/+hyyyyyysss-+++ssoyyhyoo/:                   
                      -+:osssoso:- :syyyyssysssoyy+++/os.                       
                         `-ooss/.////ho+-/s+os+/.:.:syo+y+`                     
                          -/--+-    :h/o `y/+-      ./-::`                      
                                     -yd:s:`                                    
                                      .hd.                                      
                                       /h                                       
                                       oy                                       
                                      `yy                                       
                  `````````.........--:yh-------..........```````               
               ````````......----------------.........``````````                
",@"                                                                                
                                                                                
                                ``                                              
                               `+o+//` ``                                       
                             .++osyy/ -+s+//---.                                
                            .:osyhhys+/ssyyyyyyy-  `                            
                           -oyyyydhsyyyyyhyyyhyyhoo+../::`                      
                      `-:--oysyyydhhhhhhhyyyyyyhyddyssyyhy:                     
                      /ssyysyyyyyddhyhhyhdhhhhhyhhddddddddh+.                   
                     -++syyyyhhhhhhhhhhsyyydhyyhyhdhdhydddso`                   
                     :oosyy+ssyhyoshyh+yyyyyhy++//hhdyoyo/:/`                   
                     :/+osyyssyy/s:+hyyyyyysss:+/+soosyyyoo/:`                  
                      :/:ossssyo/. :shyyyssysyooyy++o/+s-                       
                         .:ooss:.///+ho+:/s/os+/.-.:syooyo`                     
                          --..+-    :h/o `y/+-      .:---`                      
                                     -hd:y:`                                    
                                      .hd.                                      
                                       /h                                       
                                       oy                                       
                                      `yy`                                      
                  `````````.........--:yh-------..........```````               
               ````````......----------------.........``````````                
",@"                                                                                
                                                                                
                                .`                                              
                               `+oo++` ``                                       
                             .oossyy+`:oso++:-:.                                
                            ./ssyhhyso/ssyyyyyyy:  `                            
                           :syyyydhsyyyyyhhyyhyyhoso.-///`                      
                      .:/::syyyyydhhhhhhhyyyyyhyyddhysyyhy/                     
                      +ssysyyhysyddhyhhyhdhhhhhhhhddddddddho-                   
                     :++syysyhhhdddhhhhsyyydhyyhyhdddhydddso.                   
                     :oosyy+ssyhyoshyhoyyyyyhs/+//hhdyoyo/:/`                   
                    `:++osyyssyy/s:+hyhyyyhsss:+++soosyyyoo/:`                  
                      //:osossyo/. :yhyyysyysyooyy++so+s.                       
                         .:osss-.///oyo+:/y/os+/.-.-sysoys.                     
                          --..+-    :h/o `y/+-      `:---`                      
                                     -yd:y:                                     
                                      .hd.                                      
                                       /h                                       
                                       oy                                       
                                      `yy`                                      
                  `````````........---:yh-------..........```````               
               ```````.......----------------.........``````````                
",@"                                                                                
                                                                                
                               `-``                                             
                               `+sso+` `.                                       
                             .oossyyo.:oso++/::-                                
                           `-+ssyhhyso+ssyyyyyyy/ `.                            
                          `/syyhyhhsyyhyyhhyyhyyhsoo.:///.                      
                      -/+//syyyshdhhhhhdhyyyyyhhyhdhyyyyhy+`                    
                      /ssysyhhysyddhyhhyhddhhyyhhhddddddddho:                   
                     :++syhsyhhddddhhhhsyyyddyyhyhdddhydddso.                   
                    `:oosyyosyyhy+sdyhoyyyyyhs/+:/hhdyoyo//+`                   
                    .:+oosysssyy/s-ohyhyyyysso:o++s++syyyo+//.                  
                      //:ossssyo+. :yhyyssyysyooyy+oys/s-`                      
                         .:osss-.///oyo+//y/os+/`-..+yssyy:                     
                          --.`+.    :y/o `h/+-       --..`                      
                                     :yd/y:                                     
                                      .hd.                                      
                                       /h                                       
                                       oy                                       
                                      `yy`  `                                   
                  ````````.........---:yh-------..........```````               
               ```````......-----------------.........``````````                
",@"                                                                                
                                                                                
                               `-```                                            
                              ``/ssoo. `.`                                      
                             .osssyyo-:ossoo///-                                
                           `:+syyhhyss+sshyyyyyy+``.                            
                          `+syyyyhhsyyhyyhhyyyyyhsos-:+++.                      
                      :+o/ossyyshdhhhhhdhhyyyyhhyhddyyyyyho.                    
                     `+ssyyyhhyshddhyhhyhddhdyyhhdddddddddhs/                   
                     /oosyysyhhddddhhhyyyyyddyyhyhdddhhhddso.                   
                    `:+osyyoyyyhy+sdyhoyyyyyhs/+:/hhdyoyo//+`                   
                    `/oooyysssys/s-ohyhyyyhsso:o++o++syyyo+//.                  
                     `/::sssssys+` :yyyyssyysyoosy+oyy:y:`                      
                         ./osss..///syo++/y/os+/....+yssyy/                     
                          -.``+`    /y/o `h/+:       --`.`                      
                                     :yd/y:                                     
                                      .hd.                                      
                                       /h                                       
                                       oy                                       
                                      `yy`  `                                   
                  ````````.........---:yh-------..........````````              
               ```````......------------------........``````````                
",@"                                                                                
                                                                                
                               .:.```                                           
                              .`/syo+. `-`                                      
                             `osssyyo-:ossss+//:                                
                           .:osyydhyss+syhyyyyyyo``.                            
                          `+syyyyhhyyyhhyhhyyyyyhsos./++o-`                     
                      /os+ssyyyshddhhhhdhhyyhyhhyhddhyyyyhs-                    
                     `/oyyyyhhysyddhyhhyhddddyhhhhdddhddddds+                   
                     /ooyyhoyhhddddhhhyyyyyhhyyhhhdddhhhddso-                   
                    `:+ooyyoyyyhs+sdyhoyyyyyhy/+:/hhdyoyo+/+.                   
                    `/o+oyysssys/s-ohyhyyyhsso:oooo++shyhoo++-                  
                     `/::oosssys+` :yyyyssyysyoosy+oyy:y/.`                     
                         .+osss.`///syo+o:y/sso/...`/yysyy+`                    
                          .```/.    :y/o `h++:       .-```                      
                                     :yd/y-                                     
                                      .hd.                                      
                                       /h                                       
                                       oh                                       
                                      `yh`  ``                                  
                  ````````.........---:yh-------..........````````              
               ```````......------------------.........``````````               
",@"                                                                                
                                                                                
                               ./-``                                            
                              ..+ysso- `-.`                                     
                             `osssyho::oyysso++/                                
                           ./ssyyddyss+syhhyyyyys.`-                            
                       `` .osyyyyhhyyhhhhhhyyyyyyysy-/++o:`                     
                      osyossyyyshddhhhhdhhyyhhhhyhddhyyyyhs/                    
                     `/oyyshhdyshddhyhhyddddhyhhhhdddhdddddyo`                  
                     /ssyyhoshhdhddhhhyyyyyhhyyhhhdddhhhddso-                   
                    `-+ooyysyyyhyosdyhoyyyyyhy:o::hhdyoyo+:+.                   
                    `/o+oyyssoys+o.ohyhhyyyoso:+ooo++syhyoo++-                  
                     `:::oosssyso. :yyyyssyysyoosy+oyy/s+-.                     
                         .+osoy-`://syo+o/y/sso/...`/shyhy+.                    
                          `` `:.    :y+o `h++:       .-``                       
                                     -yd/y-                                     
                                      .hd.                                      
                                       /h                                       
                                       oh                                       
                                      `yh`  ``                                  
                 `````````.........---:yh--------..........```````              
              ````````......------------------.........``````````               
",@"                                                                                
                                                                                
                               ./-..`                                           
                              -.+ysso- `:.`                                     
                             `ossyyho::oyysso+o/`                               
                           -+ssyyddyssosyhyyyyyyy..-                            
                      `.. -oyyyyyhyyyhhhhhhyyyyyhysh/:ooo:`                     
                      osysssyyyshddhhhhddhyyhhhhyhddhyyyhhs+                    
                     .:+yysyhdyshddhyhhyddddhyhhdhdddhdddddys.                  
                    `/ssyhhsshhddddhhhsyyhyhhyyhyydddhhddds+-                   
                    `:+ooyysyyyhyoshyhoyyyyyyy:+::hhdyos++:/.                   
                    `/o+oyysssys+o.ohyhhyyyoss:+ooo++yyhyosoo:                  
                      /::oossyyso.`:yyyyssyysyo+ssoohh/y+--                     
                         `+oooy.`://syo+o/s+sss+...`:syyhh+-                    
                             `:`    :y+o `ho+:       .-``                       
                                     -yd/y-                                     
                                      .hd.                                      
                                       /h                                       
                                       oh                                       
                                      `yh```                                    
                 `````````.........---:yh--------..........```````              
              ````````......------------------.........``````````               
",@"                                                                                
                                                                                
                               .+:...                                           
                             `--+yyso- `:.`                                     
                             .ossyyho::oyyyssoo+`                               
                           -+ssysddysyosyhyyyyyyy.--`                           
                      .--`-osyyyyhyyyhhhhhhyyyyyhyyh/-ooo/.                     
                      +shyssyyyyyddhhhdddhyyhhhhhhdddyyhhhyo`                   
                     .:+yyyyhdhyhddhyhhyddddhyhddddddydddddhy-                  
                    `/ssyhhyshhddddhhhyyyhyhhyyhyhdddhhddds+-`                  
                    `-+ooyhsyhyhyoshyhoysyyyyy:+//hhdyoso+::.                   
                    `/o++yysssyy+o.ohyhhysysss:oooo++yyhyssys/`                 
                      :-:oossyyso.`:yyyyyyyysyo+ssoohh/y+-:                     
                         `+o+oy. ://syo+o/s/sss+...`-syyhho-                    
                             `:`    :y+o `ho+/       .-``                       
                                     -yd+y-                                     
                                      .hd.                                      
                                       /h                                       
                                       oh                                       
                                      `yh```                                    
                 `````````.........---:yd--------..........```````              
              ````````......-------------------........```````````              
"
            };
            foreach (var item in listaFrames)
            {
                Thread.Sleep(30);
                Console.Clear();
                Console.WriteLine(item);
            }
        }

    }
}
