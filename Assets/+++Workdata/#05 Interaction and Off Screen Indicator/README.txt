Interaction and Off Screen Indicator

Verwendet wurde in diesem Beispiel das kostenlose Asset von Explosive

https://assetstore.unity.com/packages/3d/animations/rpg-character-mecanim-animation-pack-free-65284

Auf dem Player können alle Scripte bis auf "Player Weapon Switch" ignoriert werden.


Mit der Taste X können Waffen getauscht werden. Dabei ändert sich im unteren Bereich das Icon.

Dies geschiet mithilfe von "enum". Zeile 21 - 25.
Hier können mehrere States hinzugefügt werden. 

Das Asset von Explosive ist etwas komplex. Denn vieles wird anhand von Actions gesteuert. Wenn ihr euch in das Asset einarbeiten wollt, dann könnt ihr mich gerne fragen.


Im Ordner "OffScreenIndicator" findet ihr die herangehensweise für ein OffScreenIndicator.
Der Ai Enemy hat ein Ai Target Objekt. Auf diesem Objekt befindet sich das Target Script. 


In der Szene findet ihr zwei "Firepits"

Diese haben die Scripte "FirepitBehaviour" und "Interact Behaviour" drauf. 
Des Weiteren gibt es einen Manager mit einem UiManager und Ui Elements Script.
Mithilfe dieser Scripts kann auf das "FirepitBehaviour" und InteractBehaviour zugegriffen werden.