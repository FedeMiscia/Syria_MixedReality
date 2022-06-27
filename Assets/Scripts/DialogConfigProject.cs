// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Experimental.DialogTest
{
    /// <summary>
    /// This class is used as an example controller to show how to instantiate and launch two different kind of Dialog.
    /// Each one of the public methods are called by the buttons in the scene at the OnClick event.
    /// </summary>
    public class DialogConfigProject : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("Assign DialogLarge_192x192.prefab")]
        private GameObject dialogPrefabLarge;

        /// <summary>
        /// Large Dialog example prefab to display
        /// </summary>
        public GameObject DialogPrefabLarge
        {
            get => dialogPrefabLarge;
            set => dialogPrefabLarge = value;
        }

        [SerializeField]
        [Tooltip("Assign DialogMediume_192x128.prefab")]
        private GameObject dialogPrefabMedium;

        /// <summary>
        /// Medium Dialog example prefab to display
        /// </summary>
        public GameObject DialogPrefabMedium
        {
            get => dialogPrefabMedium;
            set => dialogPrefabMedium = value;
        }

        [SerializeField]
        [Tooltip("Assign DialogSmall_192x96.prefab")]
        private GameObject dialogPrefabSmall;

        /// <summary>
        /// Small Dialog example prefab to display
        /// </summary>
        public GameObject DialogPrefabSmall
        {
            get => dialogPrefabSmall;
            set => dialogPrefabSmall = value;
        }


        /// <summary>
        /// Opens choice dialog example
        /// </summary>
        public void OpenChoiceDialogLargePalmira()
        {
            Dialog myDialog = Dialog.Open(DialogPrefabLarge, DialogButtonType.OK, "Arco di Palmira", "L'Arco monumentale a Palmira era una grande struttura ad arco che congiungeva il tratto centrale e il tratto orientale del Grande colonnato che attraversa la città. Costruito probabilmente durante il regno di Settimio Severo, tra la fine del II e l'inizio del III secolo d.C., l'arco è stato ristrutturato negli anni 1930 per poi essere quasi completamente distrutto dalle milizie del gruppo Stato Islamico nel 2015.", true);
            if (myDialog != null)
            {
                myDialog.OnClosed += OnClosedDialogEvent;
            }
            

        }

        public void OpenChoiceDialogLargeTempio()
        {
            Dialog myDialog = Dialog.Open(DialogPrefabLarge, DialogButtonType.OK, "Tempio di Bel a Palmira", "Il tempio di Bel era un'antica struttura sacra ubicata a Palmira, in Siria e dedicata alla divinità mesopotamica Bel (adorata a Palmira insieme al dio della luna Aglibol e al dio del sole Yarhibol). Il tempio, che costituiva il centro della vita religiosa palmirena, venne consacrato nel 32 d.C. Le sue rovine erano considerate tra le meglio conservate del sito di Palmira, dal 1980 patrimonio dell'umanità dell'UNESCO. Nell'agosto 2015 il tempio è stato distrutto dai militanti del gruppo terroristico Stato Islamico.", true);
            if (myDialog != null)
            {
                myDialog.OnClosed += OnClosedDialogEvent;
            }
        }

        public void OpenChoiceDialogLargeMinareto()
        {
            Dialog myDialog = Dialog.Open(DialogPrefabLarge, DialogButtonType.OK, "Minareto di Palmira", "Come il campanile cristiano, il minareto serve a far arrivare il più lontano possibile il segnale che scandisce la giornata liturgica. Nell'Islam esso è strettamente funzionale ai 'momenti d'elezione'(awqāt) in cui deve essere validamente assolto l'obbligo della preghiera islamica, detta ṣalāt. Per ovviare al caso di fedeli sordi o che si trovano in luoghi lontani dalla moschea ove non giunge la voce del muezzin, l'annuncio della preghiera può venire fatto anche tramite l'ostensione di ampi panni bianchi dall'alto del minareto. Putroppo anche questo edificio è stato distrutto nell'agosto del 2015 dai militanti del gruppo terroristico Stato Islamico", true);
            if (myDialog != null)
            {
                myDialog.OnClosed += OnClosedDialogEvent;
            }
        }

        public void OpenChoiceDialogLargePippo()
        {
            Dialog myDialog = Dialog.Open(DialogPrefabLarge, DialogButtonType.OK, "Minareto pippo", "Minareto pippo", true);
            if (myDialog != null)
            {
                myDialog.OnClosed += OnClosedDialogEvent;
            }
        }
        
        /// <summary>
        /// Opens confirmation dialog example
        /// </summary>
        public void OpenConfirmationDialogLarge()
        {
            Dialog.Open(DialogPrefabLarge, DialogButtonType.OK, "Confirmation Dialog, Large, Far", "This is an example of a large dialog with only one button, placed at far interaction range", false);
        }


        /// <summary>
        /// Opens confirmation dialog example
        /// </summary>
        public void OpenConfirmationDialogMedium()
        {
            Dialog.Open(DialogPrefabMedium, DialogButtonType.OK, "Confirmation Dialog, Medium, Near", "This is an example of a medium dialog with only one button, placed at near interaction range", true);
        }

        /// <summary>
        /// Opens choice dialog example
        /// </summary>
        public void OpenChoiceDialogMedium()
        {
            Dialog myDialog = Dialog.Open(DialogPrefabMedium, DialogButtonType.Yes | DialogButtonType.No, "Choice Dialog, Medium, Far", "This is an example of a medium dialog with a choice message for the user, placed at far interaction range", false);
            if (myDialog != null)
            {
                myDialog.OnClosed += OnClosedDialogEvent;
            }
        }

        /// <summary>
        /// Opens confirmation dialog example
        /// </summary>
        public void OpenConfirmationDialogSmall()
        {
            Dialog.Open(DialogPrefabSmall, DialogButtonType.OK, "Confirmation Dialog, Small, Far", "This is an example of a small dialog with only one button, placed at far interaction range", false);
        }

        /// <summary>
        /// Opens choice dialog example
        /// </summary>
        public void OpenChoiceDialogSmall()
        {
            Dialog myDialog = Dialog.Open(DialogPrefabSmall, DialogButtonType.Yes | DialogButtonType.No, "Questo è l'arco di Palmira", "This is an example of a small dialog with a choice message for the user, placed at near interaction range", true);
            if (myDialog != null)
            {
                myDialog.OnClosed += OnClosedDialogEvent;
            }
        }

        private void OnClosedDialogEvent(DialogResult obj)
        {
            if (obj.Result == DialogButtonType.Yes)
            {
                Debug.Log(obj.Result);
            }
        }
    }
}
