using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Jungle_Math
{
    internal class DailyPhrase
    {
        public void SistemDailyPhrase(System.Windows.Forms.Label lblphr) 
        {
            List<string> phrase = new List<string>
            {
            "\" Cada día es una nueva aventura. ¡Aprende algo nuevo y diviértete! \"",
            "\" Eres capaz de lograr cosas increíbles. ¡Cree en ti! \"",
            "\" Los errores son lecciones disfrazadas. Aprende de ellos y sigue adelante. \"",
            "\" Sé amable y siempre tendrás amigos a tu lado. \"",
            "\" Tu imaginación es poderosa. ¡Usa tu creatividad para cambiar el mundo! \"",
            "\" La paciencia y el esfuerzo constante te llevan lejos. No te rindas. \"",
            "\" Cada pequeño acto de bondad hace una gran diferencia. \"",
            "\" Tienes una chispa única dentro de ti. ¡Déjala brillar! \"",
            "\" El respeto y la empatía te hacen una mejor persona. \"",
            "\" Nunca dejes de hacer preguntas. ¡La curiosidad es tu mejor herramienta! \"",
            "\" El trabajo en equipo hace que los sueños funcionen. ¡Colabora y triunfa! \"",
            "\" Sé valiente, incluso cuando tengas miedo. ¡El valor está en tu corazón! \"",
            "\" Los desafíos son oportunidades para crecer y aprender. \"",
            "\" El respeto empieza por uno mismo. Cuida de ti y de los demás. \"",
            "\" Cada día es una oportunidad para ser una mejor versión de ti mismo. \"",
            "\" Tus sueños son valiosos. ¡Persíguelos con pasión! \"",
            "\" La honestidad es el camino hacia la confianza y las buenas relaciones. \"",
            "\" Comparte tus alegrías y tus penas, así se hacen más ligeras. \"",
            "\" La gratitud te hace ver lo mejor de la vida. ¡Agradece siempre! \"",
            "\" Tu sonrisa puede iluminar el día de alguien. ¡No la guardes! \"",
            "\" La perseverancia te ayuda a superar cualquier obstáculo. \"",
            "\" El amor y la amistad son los mayores tesoros. Cuídalos siempre. \"",
            "\" Sé siempre curioso y aventurero. ¡El mundo está lleno de maravillas! \"",
            "\" Las buenas acciones hablan más fuerte que las palabras. \"",
            "\" Tu esfuerzo y dedicación te llevan al éxito. ¡No te detengas! \"",
            "\" El respeto a los demás comienza con el respeto a ti mismo. \"",
            "\" La diversidad nos hace únicos. ¡Aprende de todos! \"",
            "\" La felicidad se encuentra en las pequeñas cosas. Disfruta cada momento. \"",
            "\" Tienes la fuerza para superar cualquier desafío. ¡Confía en ti! \"",
            "\" La bondad es el lenguaje que todos entienden. ¡Habla con el corazón! \"",
            "\" La amabilidad es contagiosa. ¡Pásala! \"",
            "\" Aprende algo nuevo cada día. ¡El conocimiento es poder! \"",
            "\" Los verdaderos amigos te aceptan tal como eres. \"",
            "\" La perseverancia es la llave del éxito. ¡Sigue adelante! \"",
            "\" Sé tú mismo; los demás ya están ocupados siendo ellos. \"",
            "\" El coraje es hacer lo correcto, incluso cuando es difícil. \"",
            "\" El amor propio es el primer paso hacia la felicidad. \"",
            "\" Cada día es una oportunidad para ser feliz. \"",
            "\" El respeto es la base de todas las relaciones. \"",
            "\" El fracaso es solo una parada en el camino al éxito. \"",
            "\" La alegría se encuentra en compartir con los demás. \"",
            "\" Ser curioso te lleva a grandes descubrimientos. \"",
            "\" El esfuerzo diario te acerca a tus sueños. \"",
            "\" La gratitud convierte lo que tienes en suficiente. \"",
            "\" Tus palabras tienen poder. ¡Úsalas sabiamente! \"",
            "\" Las pequeñas acciones crean grandes cambios. \"",
            "\" El respeto hacia los demás empieza con el respeto hacia ti. \"",
            "\" La empatía te ayuda a entender y a ayudar a los demás. \"",
            "\" La paciencia es la clave para alcanzar tus metas. \"",
            "\" Cada día es un nuevo comienzo. ¡Aprovéchalo! \"",
            "\" Tus sueños son importantes. ¡Nunca los abandones! \"",
            "\" La honestidad te hace digno de confianza. \"",
            "\" El aprendizaje nunca se detiene. ¡Sigue explorando! \"",
            "\" La bondad no cuesta nada, pero vale mucho. \"",
            "\" El éxito viene de pequeños esfuerzos repetidos cada día. \"",
            "\" La diversidad es nuestra mayor fortaleza. \"",
            "\" La positividad atrae cosas buenas a tu vida. \"",
            "\" Eres valioso tal como eres. ¡No necesitas cambiar! \"",
            "\" El respeto mutuo crea un mundo mejor. \"",
            "\" La felicidad se encuentra en los momentos simples. ¡Disfrútalos! \""
            };


            DateTime fechaActual = DateTime.Now;
            int indiceFrase = fechaActual.DayOfYear % phrase.Count;
            lblphr.Text = phrase[indiceFrase];
        }
    }
}
