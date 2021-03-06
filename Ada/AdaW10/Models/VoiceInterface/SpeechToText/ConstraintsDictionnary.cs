﻿using Windows.Media.SpeechRecognition;

namespace AdaW10.Models.VoiceInterface.SpeechToText
{
    public class ConstraintsDictionnary
    {

        public static ISpeechRecognitionConstraint ConstraintForHelloAda => new SpeechRecognitionListConstraint(new[]
        {
            "hey ada", "salut ada", "hello ada", "coucou ada", "bonjour ada"
        },
        "constraint_hello_ada");

        public static ISpeechRecognitionConstraint ConstraintForEvents => new SpeechRecognitionListConstraint(new[]
        {
            "évènement", "événement", "evennement", "event", "névènement", "zévènement", "deszévénement", "des zévénements", 
            "voir les zévènement", "voir les zévènement du mic", "montre moi les zévènement"
        }, 
        "constraint_events");

        public static ISpeechRecognitionConstraint ConstraintForReservation => new SpeechRecognitionListConstraint(new[]
        {
            "réserver", "réservation", "réserver une salle", "réserve moi une salle"
        }, 
        "constraint_reservation");

        public static ISpeechRecognitionConstraint ConstraintForCertification => new SpeechRecognitionListConstraint(new[]
        {
            "certification", "certif", "examen", "test", "exam"
        },
        "constraint_certification");

        public static ISpeechRecognitionConstraint ConstraintForOtherWords => new SpeechRecognitionListConstraint(new[]
        {
            "autre", "aucun", "rien"
        },
        "constraint_other_words");

        public static ISpeechRecognitionConstraint ConstraintForSandwichs => new SpeechRecognitionListConstraint(new[]
        {
            "j'ai faim ada", "commander un sandwich", "commande moi un sandwich"
        },
        "constraint_sandwich");
        public static ISpeechRecognitionConstraint ConstraintForCallingSomeone => new SpeechRecognitionListConstraint(new[]
        {
            "appeler quelqu'un", "je voudrais appeller quelqu'un", "je désire appeler quelqu'un", "je souhaiterais appeler quelqu'un"
        },
        "constraint_calling");

        public static ISpeechRecognitionConstraint ConstraintForAbortWords => new SpeechRecognitionListConstraint(new[]
        {
            "annuler", "au-revoir", "terminer", "sortir", "quitter", "retour", "merci", "bonne journée"
        },
        "constraint_abord_words");

        public static ISpeechRecognitionConstraint ConstraintForMeeting => new SpeechRecognitionListConstraint(new[]
        {
            "réunion", "meetings", "meeting", "miting"
        },
        "constraint_meeting");

        public static ISpeechRecognitionConstraint ConstraintForToDescribeSomeOne => new SpeechRecognitionListConstraint(new[]
        {
            "Décris moi", "Qui suis je", "Donne moi mon age"
        }, 
        "constraint_description");

        public static ISpeechRecognitionConstraint ConstraintForYes => new SpeechRecognitionListConstraint(new[]
        {
            "oui", "ouais", "yep", "yes", "wé", "correct"
        }, 
        "constraint_yes");

        public static ISpeechRecognitionConstraint ConstraintForNo => new SpeechRecognitionListConstraint(new[]
        {
            "non", "no", "pas du tout", "faux", "nope"
        }, 
        "constraint_no");
        
        public static ISpeechRecognitionConstraint GetConstraintForName()
        {
            return new SpeechRecognitionTopicConstraint(SpeechRecognitionScenario.FormFilling, "Person Name");
        }
    }
}
