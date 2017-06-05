namespace ForoIA.Migrations.ForoDb {

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ForoDbConfig : DbMigrationsConfiguration<ForoIA.Models.Db.ForoDbContext> {

        public ForoDbConfig() {

            AutomaticMigrationsEnabled = true;

            MigrationsDirectory = @"Migrations/ForoDb";

        }

        protected override void Seed(ForoIA.Models.Db.ForoDbContext context) {

            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "Redes Neuronales" });
            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "Sistemas Expertos" });
            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "Robotica" });
            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "Algoritmos Genéticos" });
            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "VideoJuegos" });
            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "Domótica" });

            context.Dificulty.AddOrUpdate(new Models.Db.Dificulty() { Name = "Facil" });
            context.Dificulty.AddOrUpdate(new Models.Db.Dificulty() { Name = "Medio" });
            context.Dificulty.AddOrUpdate(new Models.Db.Dificulty() { Name = "Dificl" });
            context.Dificulty.AddOrUpdate(new Models.Db.Dificulty() { Name = "Un poco de todo" });

            context.QuestionType.AddOrUpdate(new Models.Db.QuestionType() { Description = "Abierta" });
            context.QuestionType.AddOrUpdate(new Models.Db.QuestionType() { Description = "Cerrada" });

            context.Topic.AddOrUpdate(new Models.Db.Topic() { Description = "Unidad 1. " });
            context.Topic.AddOrUpdate(new Models.Db.Topic() { Description = "Unidad 2. " });
            context.Topic.AddOrUpdate(new Models.Db.Topic() { Description = "Unidad 3. " });
            context.Topic.AddOrUpdate(new Models.Db.Topic() { Description = "Unidad 4. " });
            context.Topic.AddOrUpdate(new Models.Db.Topic() { Description = "Unidad 5. " });

            context.SaveChanges();

            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué es la inteligencia artificial?", DificultId = 1, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Se puede definir la IA como:", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Características de la IA:", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La IA es el estudio de técnicas de resolución de problemas de complejidad exponencial mediante el uso de conocimiento sobre el campo de aplicación del problema?", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Área de las ciencias computacionales encargadas de la creación de hardware y software con comportamientos inteligentes", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La IA es parte de la ______ que concierne al diseño de sistemas inteligentes para el computador:", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Los sistemas inteligentes presentan características asociadas con el comportamiento humano inteligente?", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La interesante tarea de lograr que las computadoras piensen… máquinas con mente, en su amplio sentido literal. Fue enunciado por: ", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "“La automatización de actividades que vinculamos con procesos de pensamiento humano, actividades tales como toma de decisiones, resolución de problemas, aprendizaje…” Fue enunciado por:", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "“El arte de crear máquinas con capacidad de realizar funciones que realizadas por personas requieren de inteligencia.” Fue enunciado por:", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "“El estudio de cómo lograr que las computadoras realicen tareas que, por el momento, los humanos hacen mejor.” Fue enunciado por:", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "“El estudio de las facultades mentales mediante el uso de modelos computacionales.” Fue enunciado por:", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "“El estudio de los cálculos que permiten percibir, razonar y actuar.” Fue enunciado por:", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "“Un campo de estudio que se enfoca a la explicación y emulación de la conducta inteligente en función de procesos computacionales.” Fue enunciado por:", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "“La rama de la ciencia de la computación que se ocupa de la automatización de la conducta inteligente.” Fue enunciado por:", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La IA es el estudio de cómo lograr que las computadoras sean más grandes?", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La IA es una técnica de diseño de sistemas informáticos que presentan características inteligentes?", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La IA es la ciencia de hacer máquinas para automatizar procesos mecánicos?", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Es parte de la ciencia computacional que estudia procesos de símbolos antiguos?", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La IA es una de las disciplinas más nuevas en el campo de las ciencias computacionales?", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué tipo de inteligencia posee una computadora diseñada para IA?", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La IA se remota a los intentos por crear ______:", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿En qué lugar fue el nacimiento de la IA?", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El nacimiento de la IA fue en la reunión celebrada en el Dartmouth College.", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Quienes se encontraban en el Dartmouth College?", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En 1956, se celebró el nacimiento de la inteligencia artificial en Darthmouth College?", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En los años _______ se logra realizar un sistema que tuvo cierto éxito, el “Perceptrón de Rossenblatt", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Algunos sistemas de la IA son:", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Las ciencias que aportan a la IA son: Filosofía, Matemáticas, Psicología, Lingüística y Ciencias de la comunicación", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué es una técnica de IA?", DificultId = 3, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Áreas y aplicaciones de la IA:", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Una computadora juega un papel fundamental en el área científica, educativa, negocios y entretenimiento", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La búsqueda de los principios que rigen la inteligencia para incorporarlos en una máquina, es moderna", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué buscaban explicar los griegos?", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El caso Gottfried Leibnitz buscaba encontrar un álgebra capaz de representar todo el conocimiento incluyendo las verdades morales y metafísicas que pudieran lograr un sistema deductivo", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué propuso Alan Turing en 1950?", DificultId = 2, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿En qué años nace la IA?", DificultId = 2, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Quiénes desarrollaron el GPS?", DificultId = 3, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué propuso Herbert Simon?", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Las investigaciones sobre IA se orientaron a buscar métodos para:", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Por qué se esperaban más resultados desde el punto de vista de los negocios?", DificultId = 1, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué predijo E. Dyson en los 80’s?", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los sistemas inteligentes ayudan a _____________", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El enfoque basado en el comportamiento proporciona una noción amplia del concepto de inteligencia…", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El enfoque basado en el comportamiento se enfoca en:", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La IA basada en el comportamiento concibe a los sistemas como grandes rompecabezas?", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La implementación de la IA basado en el comportamiento debe estar basado en un sistema incremental teniendo subsistemas en su implementación", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Sony, General Electric y Microsoft no tienen grupos para el desarrollo de productos de IA", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La IA proporciona__________:", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El avance de la IA se basa en el avance del________", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los sistemas creados por IA deben contribuir a:", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El uso del aprendizaje virtual se utiliza para la capacitación de personas, resolución de problemas y de conocimiento", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Es auxiliar en la recuperación de enfermedades:", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La idea del desarrollo de la IA es hacer a las personas más listas a través de proporcionar el acceso y facilitar la presentación de la información", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La incorporación de estas nuevas tecnologías implica un olvido de las antiguas formas de trabajo, no existe balance entre la nueva y vieja tecnología", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La inteligencia humana abarca muchas otras habilidades que difícilmente son igualadas por una máquina", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "No existen limitaciones en los avances importantes en el campo de la IA", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El algoritmo debe acabar tras un número finito de pasos…", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El algoritmo debe definirse de forma precisa para cada paso…", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El algoritmo tendrá cero o más entradas…", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El algoritmo tiene una o más salidas, en relación con las entradas", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Se entiende por esto que una persona sea capaz de realizar el algoritmo de modo exacto y sin ayuda de una máquina en un lapso de tiempo finito", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los algoritmos no requieren de una organización compleja de datos", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El algoritmo de Euclides es un algoritmo de los más antiguos conocidos", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿En qué consistía el algoritmo de Euclides?", DificultId = 3, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En cada paso del algoritmo se determina de forma única el siguiente paso", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Deben decidir en cada paso de la ejecución entre varias alternativas y agotarlas todas antes de encontrar la solución", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Período transcurrido entre el inicio y la finalización del algoritmo", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Cantidad que necesita el algoritmo para su ejecución", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La capacidad y diseño de la máquina pueden afectar al diseño del algoritmo", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Aquellos que son proporcionales a N^k", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Aquellos que son proporcionales a k^N", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Aquellos que no se pueden resolver mediante un algoritmo", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Aquellos que cuentan al menos con un algoritmo para su cómputo", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Aquellos para los que no es factible obtener su solución", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Aquellos para los que existe al menos un algoritmo capaz de resolverlo en un tiempo razonable", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Defina Heurística", DificultId = 2, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Existen varios algoritmos heurísticos en la IA por naturaleza", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué es la lógica proposicional?", DificultId = 2, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La lógica proposicional no se preocupa por la manera de representar las cosas", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué significan las constantes lógicas (T) y (?)?", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué símbolos de puntuación se utilizan para evitar ambigüedad?", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Cada conector lógico es definido por una tabla de verdad", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Mencione ¿Qué es la semántica?:", DificultId = 1, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La semántica de un lenguaje proposicional depende de:", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Se emplean en la lógica para determinar posibles valores de verdad en una expresión…", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La negación consiste en cambiar el valor de verdad de una variable proposicional", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La disyunción quiere decir que la sentencia será verdadera cuando una o ambas variables sean verdaderas", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La conjunción es que la sentencia será verdadera sólo cuando ambas variables sean negativas", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Bicondicional es cuando la sentencia será verdadera cuando ambas variables proposicionales sean iguales", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = " La disyunción exclusiva consiste en que la sentencia será falsa solo cuando solo una de las dos variables proposicionales sea falsa pero no las dos", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es un componente importante de un sistema LISP?", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El nombre LISP es la abreviatura de ___________.", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "LISP fue desarrollado para el procesamiento de colas", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La estructura más importante de la lista", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Ofrece la posibilidad de realizar definiciones recursivas de funciones mediante la unión de procedimientos", DificultId = 2, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Cada función y cada programa LISP tiene estructura de lista", DificultId = 3, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "PROLOG es la abreviatura de PROgramación LOGica…", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cómo se aplica PROLOG en la actualidad?", DificultId = 2, QuestionTypeId = 1, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Las principales características de PROLOG son:", DificultId = 1, QuestionTypeId = 2, TopicId = 1 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué es un agente inteligente?", DificultId = 1, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuáles son los elementos que conforman la estructura de un agente inteligente?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Un robot clasificador de partes y un sistema de diagnóstico médico son ejemplos de agentes inteligentes?", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Los agentes inteligentes no suelen emplear acciones o percepciones para lograr una meta específica?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuáles de las siguientes opciones pertenecen a tipos de agentes inteligentes?", DificultId = 3, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué es un agente de reflejo simple?", DificultId = 2, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál de las siguientes opciones pertenece a ambientes para un agente inteligente?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es la tarea de un agente de búsqueda de información o rastreador?", DificultId = 1, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La mayoría de los agentes poseen tres características principales: Comunicación, inteligencia y autonomía?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Un agente no es capaz de hacer sugerencias al usuario mucho menos actuar de forma autónoma?", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es la definición de un sistema experto?", DificultId = 1, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Los sistemas expertos son programas que capturan el conocimiento de un experto e imitan sus procesos de razonamiento al resolver los problemas de un determinado dominio?", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La estructura básica de un sistema experto difiere mucho de la regla: SI premisa, ENTONCES conclusión?", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es la principal característica de los sistemas expertos?", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Los sistemas expertos pueden resolver con mucha facilidad problemas complejos?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los sistemas expertos no hacen uso de:", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Los sistemas expertos son capaces de dar prioridad a ciertos eventos y de tomar decisiones de forma autónoma?", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué son las redes neuronales?", DificultId = 1, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿A las redes neuronales se les inculca diferentes tipos de reglas para que sean capaces de aprender a reconocer patrones?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuáles son algunas de las habilidades más importantes de las redes neuronales?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Las redes neuronales no son apropiadas para:", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué es la lógica difusa?", DificultId = 1, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Los sistemas basados en lógica difusa han mostrado gran utilidad en tareas de reconocimiento de patrones y validación de crédito financiero por ejemplo?", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿A diferencia de las redes neuronales en lógica difusa es más difícil examinar y entender sus bases de conocimiento?", DificultId = 3, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué son los algoritmos genéticos?", DificultId = 1, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es el principal objetivo de un algoritmo genético?", DificultId = 1, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿En qué áreas se han aplicado los algoritmos genéticos?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Una de las principales tareas de la IA es potenciar a la computadora para que sea capaz de identificar la voz humana en general y de responder en forma hablada?", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué estudia la robótica?", DificultId = 1, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿En qué campo es más visible la tecnología de la Inteligencia Artificial?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La robótica va de la mano con el reconocimiento de patrones, la ingeniería del conocimiento, la toma de decisiones y la comprensión del lenguaje?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuáles son las características generales de un sistema experto?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Es la parte esencial de un sistema experto", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Una característica decisiva de los sistemas expertos es la separación entre conocimiento por un lado y su procesamiento por el otro?", DificultId = 3, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué contiene la base de conocimientos de un sistema experto?", DificultId = 2, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿El mecanismo de interferencia de un sistema experto no puede simular la estrategia de solución de un experto?", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es el propósito del Componente Explicativo en un Sistema Experto?", DificultId = 3, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Para qué sirve la Interfaz de Usuario en un Sistema Experto?", DificultId = 2, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es la función del Componente de Adquisición en un Sistema Experto?", DificultId = 3, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Los sistemas expertos que cuentan con información relacionada con la utilidad están en ventaja con respecto de los sistemas de interferencia puros?", DificultId = 3, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Entre los puntos más importantes para la elaboración y utilización de sistemas expertos se encuentran el definir el alcance del problema, definir la topología y asignar probabilidades y utilidades?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál de los siguientes pasos es el primero en la elaboración de sistemas expertos?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál de los siguientes pasos es el último en la elaboración de sistemas expertos?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Es una característica de un Sistema Experto: ", DificultId = 3, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Es una característica de un Sistema Clásico: ", DificultId = 3, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "NO es una característica de un Sistema Experto: ", DificultId = 3, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "NO es una característica de un Sistema Clásico: ", DificultId = 3, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Un sistema experto es muy eficaz cuando tiene que analizar una gran cantidad de información, interpretándola y proporcionando una recomendación a partir de la misma?", DificultId = 2, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Un sistema experto no es una expresión de un sistema basado en el conocimiento?", DificultId = 1, QuestionTypeId = 2, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuáles son las capacidades que comprende un sistema basado en el conocimiento?", DificultId = 3, QuestionTypeId = 1, TopicId = 2 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuáles son los métodos de resolución de problemas en la inteligencia artificial?", DificultId = 2, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Para qué se utiliza el paradigma de generación y prueba?", DificultId = 3, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuáles son las propiedades de un paradigma de generación y prueba?", DificultId = 3, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Para realizar la generación de prueba se tiene que encontrar una solución satisfactoria para generar más soluciones posibles?", DificultId = 2, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Un estado en inteligencia artificial es:", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La representación Espacio-Estado utiliza varios métodos de búsqueda a través de bases de datos para alcanzar soluciones", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cómo se puede hacer la búsqueda de un camino de solución a través del espacio-estado?", DificultId = 2, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los nodos apuntan al nodo final para saber su recorrido", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los caminos falsos en IA son representados por los…", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los gráficos se representan por medio de árboles", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué representa el espacio-estado?", DificultId = 2, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Son 3 técnicas para la búsqueda de una posible solución", DificultId = 2, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Para la evaluación de una técnica de una búsqueda se necesitan dos medidas elementales, las cuales son:", DificultId = 1, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es la diferencia entre encontrar una solución óptima y una solución buena?", DificultId = 2, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿En qué consiste la técnica de búsqueda del primero en profundidad?", DificultId = 2, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿En qué consiste la técnica del primero en amplitud?", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué es heurística?", DificultId = 1, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿En que consiste la técnica de búsqueda de ascenso de la colina?", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La técnica del ascenso de la colina surgió de la analogía de un excursionista que se perdió en la obscuridad en medio de una montaña?", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La técnica de búsqueda del menor coste es…", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La técnica de haz es parecida a la búsqueda en amplitud en cuanto a que avanza nivel por nivel. Sin embargo, a diferencia de esta, la búsqueda en haz se mueve hacia abajo solo a través de los mejores nodos de cada nivel; los otros nodos se ignoran.", DificultId = 2, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Si no se puede aplicar una heurística a un problema, ¿Qué se hace?", DificultId = 2, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El método de eliminación de caminos…", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué hace el método de eliminación de nodos?", DificultId = 1, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El método de reducción del problema consiste en", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué es un árbol de metas?", DificultId = 1, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Los constructores, qué función tienen en la IA?", DificultId = 2, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los árboles de metas no pueden hacer transparente la interacción entre  procedimientos", DificultId = 2, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La resolución de problemas es fundamental para la mayoría de las aplicaciones de la IA", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La capacidad de resolver problemas suele usarse como una medida de la inteligencia artificial para:", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué es un método ciego?", DificultId = 2, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Contar con información sobre un espacio de estados evita a los algoritmos emprender búsquedas a ciegas, permitiendo así encontrar soluciones con más eficiencia", DificultId = 2, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿La búsqueda preferente por lo mejor se utiliza cuando los nodos se desordenan de manera que se expande primero aquel con mejor evaluación?", DificultId = 2, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La búsqueda avara consiste en", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El método de búsqueda avara es característico por:", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El método búsqueda A se caracteriza por:", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La búsqueda preferente por amplitud siempre se expande uno de los nodos que se encuentre en lo más profundo del árbol", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La búsqueda preferente por profundidad se caracteriza por:", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Su desventaja principal es:", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La búsqueda limitada por profundidad:", DificultId = 2, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La representación en forma de procedimientos/subrutinas se caracterizan por:", DificultId = 3, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El método de análisis de medios y metas representa un estado y cada enlace una posible transición de un paso de un estado a otro", DificultId = 2, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Un estado de representación consta de que:", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Una red semántica es un tipo de red en la cual los nodos no representan conceptos, objetos o situaciones y los arcos no representan relaciones entre ellos", DificultId = 2, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Desde el punto de vista estructural de la red semántica, cada enlace conecta un nodo cola con uno cabeza", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Para la semántica operativa debe haber:", DificultId = 3, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La comprensión del lenguaje consiste en:", DificultId = 3, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En un método de uso más frecuente se conservan las limitaciones en cuanto a expresividad y para cubrir los vacíos se utiliza la vinculación procedimientos", DificultId = 3, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Para Minsky, ¿Cuáles son los tres tipos de conocimiento que distingue?", DificultId = 2, QuestionTypeId = 1, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El conocimiento de depuración es el que permite saber qué hacer cuando no se conoce algo, lo que se conoce no funciona, o hay una equivocación.", DificultId = 1, QuestionTypeId = 2, TopicId = 3 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En el caso de los poliarboles el tiempo de cálculo es una función lineal al tamaño de la red.", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En los dominios reales, la estructura local tiende a que las cosas sean más difíciles.", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En los dominios reales es posible utilizar técnicas de aproximación.", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Los métodos de planeación fueron desarrollados en gran medida para? ", DificultId = 3, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Herramienta que nos ayuda a identificar que conocimiento es requerido por los participantes del proceso?", DificultId = 2, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Herramienta que nos permite clasificar los elementos de una manera que faciliten la estructuración y generación de la base de conocimientos de la organización?", DificultId = 3, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué es un agente inteligente?", DificultId = 1, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Quiénes permitieron el poder pensar en la IA al concebir a la mente con maneras diversas, esto desde 400 a.C.?", DificultId = 1, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué herramienta es proporcionada para manipular las aseveraciones de certeza lógica, así como las inciertas de tipo probabilistas?", DificultId = 2, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Quiénes reforzaron la idea de que los humanos y otros animales podían ser considerados como máquinas para el procesamiento de la información?", DificultId = 2, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Quiénes demostraron que el uso del lenguaje se ajusta al sistema de creencias?", DificultId = 1, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué ingeniería ofreció el dispositivo que permite hacer realidad las aplicaciones de IA?", DificultId = 1, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En el caso de la lógica de primer orden, ¿Qué significa e razonamiento adecuado?", DificultId = 3, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En el caso de la lógica de primer orden, ¿Qué significa la probabilidad?", DificultId = 3, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El razonamiento eficiente mediante la probabilidad es tan reciente que solamente hay un método. ¿Cuál es ese razonamiento?", DificultId = 3, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué constituye una red de creencia?", DificultId = 2, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Que es una red de creencia?", DificultId = 1, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuáles son los métodos por los cuales las redes de creencia pueden razonar?", DificultId = 3, QuestionTypeId = 1, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Es aquel que emprende la mejor acción posible en una situación dada.", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Representa la distribución de probabilidad conjunta correspondiente a un dominio.", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En el caso de la logística de primer orden, el razonamiento adecuado significa:", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En el caso de la probabilidad que significa razonamiento adecuado.", DificultId = 1, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Que es una red de creencias? ", DificultId = 1, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La lógica moderna se desarrolló a partir de:", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Tendencia principal dentro de la deducción automática.", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Uno de los impulsores de la deducción automática no basada en resolución.", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La lógica moderna se desarrolla a partir de la confluencia de matemáticas, ingeniería y lingüística.", DificultId = 1, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Tener conocimientos sobre el dominio de discurso, conocer como dirigir o guiar tal razonamiento son capacidades propias de la lingüística.", DificultId = 1, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En el siglo XX casi todos los esfuerzos para automatizar las matemáticas estuvieron dirigidos hacia la mecanización de la aritmética.", DificultId = 1, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Desde la perspectiva histórica podemos identificar la tendencia principal dentro de la reducción automática como el proceso de razonamiento humano.", DificultId = 1, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "A. Newell fue el primer programador de deducción automática.", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "A. Newell fue el primero en implementarla. ", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La formulas llamadas cláusulas de Hornz las creo A.Newell.", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "W.W. Bledsoe fue uno de los impulsores de la deducción automática no basada en resoluciones.", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El punto clave para obtener algoritmos de satisfacibilidad eficientes es la capacidad de controlar el proceso de ramificación.", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El punto clave para obtener algoritmos de satisfacibilidad eficientes es el foque de la metodología TAS.", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Para determinar la factibilidad de una formula dada, en primer lugar, se intenta reducir el tamaño de la misma mediante la aplicación sucesiva lineal.", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "J.R. Guard desarrollo los sistemas llamados SAM.", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Uno de los sistemas interactivos más conocidos en IA hasta la fecha es.", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "n(n(x+y)+n(x+n(y)))=x. la siguiente ecuación pertenece a:", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Es un conjunto de acciones que cuando está ejecutada permite alcanzar la meta:", DificultId = 1, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Es una de las principales áreas de planeación de la IA.", DificultId = 1, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La representación del conocimiento determina:", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La primera fase de la adquisición del conocimiento desde un experto depende de:", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Una ventaja de los sistemas expertos es:", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Una fase de la adquisición del conocimiento.", DificultId = 1, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Es un sistema basado en conocimiento único, se relaciona con el entorno.", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Es un sistema basado en conocimiento, está integrado con otros sistemas y no se lo distingue.", DificultId = 1, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Es un sistema basado en conocimiento común.", DificultId = 2, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Operación que determina cuales son las reglas potencialmente aplicables en un estado dado en una base de datos.", DificultId = 3, QuestionTypeId = 2, TopicId = 4 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Menciona la definición de algoritmias de visión.", DificultId = 2, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Objetivo principal de la visión por computadora.", DificultId = 1, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Qué cambios hay cuando existen objetos en movimiento en una escena?", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Menciona las ópticas que aborda la estimulación 3D.", DificultId = 3, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los métodos directos estiman el flujo óptico 2-D y deducen el movimiento  3-D.", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los métodos directos 3-D pueden considerarse como una extensión de los métodos 3-D de flujo óptico.", DificultId = 2, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es el problema de la correspondencia de características?", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La rama industrial es una aplicación de los algoritmos de visión.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es el problema más difícil por resolver en la IA?", DificultId = 2, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es el tema más importante de la IA en la década de los 90?", DificultId = 2, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es el nombre del robot móvil de  McCarthy y Raphael?", DificultId = 2, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cual es la diferencia entre el robot creado por McCarthy y Raphael y los programas de computadora utilizados hasta ahora por la IA?", DificultId = 3, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Porque termino ha sido reemplazado sistema experto.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Que son los componentes basados en conocimiento de un sistema de información?", DificultId = 3, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Una de las características más importantes de los primeros Sistemas Expertos era la capacidad que tenían de ser reflexivos y responder a las cuestiones de por qué y cómo.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La estrategia que sigue el ingeniero en conocimiento es:", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Que es el modelo de tareas?", DificultId = 1, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La construcción del modelo experto es la actividad central en la construcción de un SBC.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El modelo de Tareas tiene en cuenta los requisitos de velocidad, hardware y software.", DificultId = 2, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cuál es la función de MYCIN?", DificultId = 3, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "MYCIN diagnostica y trata enfermedades del pulmón.", DificultId = 2, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El objetivo de DENDRAL es:", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Un Sistema Experto es una aplicación informática que simula el comportamiento de un experto humano.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La principal característica del experto humano viene a ser sus sentimientos o habilidades.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Que es EURISKO?", DificultId = 3, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Que es FUTUREKIDS? ", DificultId = 2, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Cual es la metodología de enseñanza de FUTUREKIDS?", DificultId = 3, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El Sophisticated Instructional Environment fue diseñado por:", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿WUSOR fue creado por quien y para que?", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Cual es el Objetivo de un modelo cognitivo.", DificultId = 3, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Este tipo de conocimiento se refiere básicamente a hechos que guardan relación con un uso especializado para un caso particular.", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Cuales son los componentes del modelo del estudiante.", DificultId = 2, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los dos tipos de conocimiento procedimental.", DificultId = 2, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "En la forma overlay, el conocimiento del modelo del estudiante queda representado como un subconjunto del conocimiento del experto.", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Las actividades administrativas, financieras y contables también son campos en los que se pueden aplicar los sistemas expertos.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Suministra la información analítica relativa a los costes de los productos y servicios generados por la empresa:", DificultId = 2, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Tiene por objeto la captación, medición y valoración de la circulación interna.", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Se centra principalmente en el proceso de racionalización, planificación y control de los costes.", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La contabilidad de gestión es una evolución lógica de la contabilidad de costes.", DificultId = 2, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Tiene como objetivo principal la preparación de los estados financieros de la empresa.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "La segunda fase del análisis de estados financieros se realizan unas predicciones y se indican los remedios o soluciones que se pueden aplicar.", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Que es la planificación financiera empresarial?", DificultId = 1, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Definición de conocimiento.", DificultId = 1, QuestionTypeId = 1, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Los conceptos de conocimiento e inteligencia no están íntimamente ligados.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Se define como creencia a…", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "Definición de Epistemología.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿Que es conocimiento declarativo?", DificultId = 2, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El conocimiento puede ser representado como imágenes mentales en nuestros pensamientos.", DificultId = 1, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "El conocimiento declarativo puede ser representado con:", DificultId = 2, QuestionTypeId = 2, TopicId = 5 });
            context.Test.AddOrUpdate(new Models.Db.Test() { Question = "¿En que nos ayuda una red inteligente?", DificultId = 3, QuestionTypeId = 2, TopicId = 5 });

            context.SaveChanges();

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 1, Description = "Se encarga del estudio de la tecnología y la ciencia del diseño de máquinas o agentes que realizan tareas que normalmente se asocian con la inteligencia humana", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 2, Description = "Nieta de la ciencia", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 2, Description = "Programación avanzada de máquinas mecánicas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 2, Description = "Ciencia de lo artificial", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 3, Description = "Moderna, uso de maquinaria pesada, adaptación al medio ambiente, simulación de inteligencia de animales, estudio de técnicas para el comportamiento de los órganos humanos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 3, Description = "Adaptación al medio ambiente, procesamiento de lenguaje natural, representación del conocimiento y razonamiento, el autoaprendizaje, la autorreflexión", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 4, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 4, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 5, Description = "Redes neuronales", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 5, Description = "Sistemas expertos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 5, Description = "Inteligencia artificial", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 5, Description = "Programación orientada a objetos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 5, Description = "Informática", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 6, Description = "Redes artificiales", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 6, Description = "Informática", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 6, Description = "Inteligencia natural", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 7, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 7, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 8, Description = "Bellman, 1978", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 8, Description = "Haugeland, 1985", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 8, Description = "Schalkoff, 1990", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 9, Description = "Bellman, 1978", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 9, Description = "Haugeland, 1985", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 9, Description = "Schalkoff, 1990", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 10, Description = "Bellman, 1978", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 10, Description = "Kurzweil. 1990", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 10, Description = "Luger y Stubblefield, 1993", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 11, Description = "Bellman, 1978", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 11, Description = "Haugeland, 1985", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 11, Description = "Rich y Knight, 1991", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 12, Description = "Bellman, 1978", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 12, Description = "Charniak y McDermott, 1985", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 12, Description = "Schalkoff, 1990", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 13, Description = "Winston, 1992", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 13, Description = "Haugeland, 1985", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 13, Description = "Schalkoff, 1990", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 14, Description = "Winston, 1992", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 14, Description = "Luger y Stubblefield, 1993", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 14, Description = "Schalkoff, 1990", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 15, Description = "Luger y Stubblefield, 1993", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 15, Description = "Winston, 1992", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 15, Description = "Schalkoff, 1990", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 16, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 16, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 17, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 17, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 18, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 18, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 19, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 19, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 20, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 20, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 21, Description = "Inteligencia animal", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 21, Description = "Inteligencia de maquinaria", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 21, Description = "Inteligencia humana", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 22, Description = "Autómatas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 22, Description = "Máquinas con pensamiento animal", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 22, Description = "Máquinas de ayuda para la decodificación de mensajes", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 23, Description = "Casa blanca, EEUU", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 23, Description = "Canadá", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 23, Description = "Hanover, EEUU", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 24, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 24, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 25, Description = "Alan Newell, Claude Shannon y Herbet Simon", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 25, Description = "Claude Shannon, Marvin Minsky y Herbert Simon", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 26, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 26, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 27, Description = "50’s", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 27, Description = "40’s", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 27, Description = "60’s", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 28, Description = "PEGASUS, MARVEL, NAVLAB, DEEP BLUE", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 28, Description = "PEGASO 99, MATLAB, COMIT, SHINE BLUE", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 29, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 29, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 30, Description = "Es un método que utiliza conocimiento representado de forma que represente generalizaciones, sea comprensible, pueda modificarse fácilmente y utilizarse en muchas situaciones", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 31, Description = "Procesamiento del lenguaje natural y la robótica", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 31, Description = "Métodos reductivos y conocimiento del lenguaje animal", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 32, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 32, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 33, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 33, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 34, Description = "Representar símbolos matemáticos con base a IA.", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 34, Description = "Representar estilos de razonamiento", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 35, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 35, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 36, Description = "Propuso el primer artículo moderno sobre la posibilidad de mecanizar la inteligencia", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 37, Description = "Nace a mediados de los años cincuenta (1956)", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 38, Description = "Allen Newell, Herbert Simon y Cliff Shaw", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 39, Description = "Conocimientos administrativos para la elaboración de máquinas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 39, Description = "Lenguaje avanzado de programación para la IA", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 39, Description = "Hipótesis del símbolo físico como una forma de representar y modelar el pensamiento humano", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 40, Description = "Organizar, planificar, programa, desarrollar, formular ecuaciones", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 40, Description = "Planear, razonar, aprender, jugar contra adversario, resolver rompecabezas, encontrar heurísticas y estrategias de gane", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 41, Description = "Debido a que se tenían sistemas expertos que emulaban el razonamiento de expertos para diagnosticar, predecir y planear", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 42, Description = "La IA no estaba madura y no podría ser importante", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 42, Description = "La IA estaba madura y podría ser importante", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 43, Description = "Implementar nuevos sistemas como ecológicos y científicos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 43, Description = "Mejorar la computación personal para resolver problemas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 43, Description = "Mejorar el comportamiento lógico de una máquina", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 44, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 44, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 45, Description = "Seres humanos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 45, Description = "Animales", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 45, Description = "Plantas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 45, Description = "Industria", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 45, Description = "Naturaleza", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 46, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 46, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 47, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 47, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 48, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 48, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 49, Description = "Ayuda remota por medio del internet", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 49, Description = "Mejoras para el medio ambiente", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 49, Description = "Nuevas formas de comunicación, acceso y conexión", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 49, Description = "Desarrollo de maquinaria", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 50, Description = "Hardware", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 50, Description = "Software", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 50, Description = "Computadoras modernas", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 51, Description = "El cuidado de los animales", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 51, Description = "El cuidado de los niños", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 51, Description = "Cuidado de personas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 51, Description = "Ahorro de dinero mediante la distribución de recursos", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 52, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 52, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 53, Description = "Computación emotiva", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 53, Description = "Computación lógica", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 54, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 54, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 55, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 55, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 56, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 56, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 57, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 57, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 58, Description = "Finitud", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 58, Description = "Definibilidad", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 58, Description = "Entrada", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 58, Description = "Salida", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 58, Description = "Efectividad", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 59, Description = "Finitud", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 59, Description = "Definibilidad", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 59, Description = "Entrada", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 59, Description = "Salida", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 59, Description = "Efectividad", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 60, Description = "Finitud", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 60, Description = "Definibilidad", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 60, Description = "Entrada", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 60, Description = "Salida", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 60, Description = "Efectividad", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 61, Description = "Finitud", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 61, Description = "Definibilidad", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 61, Description = "Entrada", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 61, Description = "Salida", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 61, Description = "Efectividad", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 62, Description = "Finitud", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 62, Description = "Definibilidad", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 62, Description = "Entrada", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 62, Description = "Salida", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 62, Description = "Efectividad", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 63, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 63, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 64, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 64, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 65, Description = "Describía la realización de operaciones elementales en el sistema de numeración decimal", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 66, Description = "Algoritmo no determinista", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 66, Description = "Algoritmo determinista", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 67, Description = "Algoritmo no determinista", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 67, Description = "Algoritmo determinista", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 68, Description = "Tiempo", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 68, Description = "Memoria", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 69, Description = "Tiempo", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 69, Description = "Memoria", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 70, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 70, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 71, Description = "Algoritmos polinomiales", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 71, Description = "Algoritmos exponenciales", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 71, Description = "Algoritmos polinomiales", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 71, Description = "Algoritmos exponenciales", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 73, Description = "Problemas decidibles", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 73, Description = "Problemas indecidibles", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 74, Description = "Problemas decidibles", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 74, Description = "Problemas indecidibles", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 75, Description = "Problemas intratables", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 75, Description = "Problemas tratables", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 76, Description = "Problemas intratables", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 76, Description = "Problemas tratables", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 77, Description = "Función matemática que sirve como una estimación del coste del camino más corto de un nodo hasta otro", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 78, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 78, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 79, Description = "Rama de la lógica clásica que estudia las proposiciones o sentencias lógicas", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 80, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 80, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 81, Description = "Bien / Mal", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 81, Description = "Correcto / Incorrecto", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 81, Description = "Verdadero / Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 82, Description = "+ - * /", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 82, Description = "(), [], {}", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 83, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 83, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 84, Description = "Permite atribuir un significado a las expresiones del lenguaje simbólico considerado", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 85, Description = "Valores de entrada y valores de salida", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 85, Description = "La interpretación y los valores de verdad", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 86, Description = "Semántica", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 86, Description = "Tablas de verdad", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 86, Description = "Tablas reales", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 87, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 87, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 88, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 88, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 89, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 89, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 90, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 90, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 91, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 91, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 92, Description = "Velocidad", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 92, Description = "Facilidad de uso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 92, Description = "Accesible", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 92, Description = "Gestión dinámica en memoria", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 93, Description = "Lista-de-Proceso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 93, Description = "Lista-de-Programación", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 93, Description = "Lista-de-Potencia", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 94, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 94, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 95, Description = "Listas y átomos", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 95, Description = "Función", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 95, Description = "Forma de trabajo", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 96, Description = "Listas y átomos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 96, Description = "Función", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 96, Description = "Forma de trabajo", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 97, Description = "Listas y átomos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 97, Description = "Función", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 97, Description = "Forma de trabajo", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 98, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 98, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 99, Description = "Se aplica como lenguaje de desarrollo en aplicaciones de IA en diferentes proyectos", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 100, Description = "Velocidad, almacenamiento, potencia, instanciación, unificación, tablas de verdad", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 100, Description = "Recursividad, recursión, instanciación, verificación, unificación", IsCorrect = true });








































































































            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 101, Description = "Es un tipo de programa informático que, por encargo de un usuario u otro programa, realiza de forma autónoma tareas que requieren cierto grado de inteligencia y aprendizaje", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 102, Description = "Agente y Hardware", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 102, Description = "Usuario y Software", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 102, Description = "Arquitectura y Programa", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 103, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 103, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 104, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 104, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 105, Description = "De reflejo simple, basados en metas y basados en utilidad", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 105, Description = "De reflejo múltiple, basados en error y sin sensor utilizable", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 105, Description = "Compuestos informados de lo que sucede y basados en experiencia", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 106, Description = "Es aquel que no contiene internamente estados y sus procesos o acciones son respuestas a la entrada de percepciones, son agentes que hacen uso de las reglas de condición-acción.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 107, Description = "Contadores, Agentes de Limpieza, Representantes Visuales", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 107, Description = "Asistentes Personales, Agentes de Búsqueda, Negociadores", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 107, Description = "Agentes Secretos, Administradores, Lectores Autónomos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 108, Description = "Rastrean en las redes de computadoras en busca de la información solicitada. Son parametrizables por el usuario o aprenden de sus hábitos, rastreas la red e informan por correo electrónico de novedades que consideran pueden ser el interés para el usuario.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 109, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 109, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 110, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 110, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 111, Description = "Es una forma de programación que emula artificialmente ciertos aspectos del razonamiento de un especialista humano en un ámbito restringido y limitado de conocimiento.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 112, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 112, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 113, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 113, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 114, Description = "Que están basados en reglas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 114, Description = "Que están basados en expertos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 114, Description = "Que son autónomos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 115, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 115, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 116, Description = "Redes de decisión", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 116, Description = "Bases de datos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 116, Description = "Representaciones explícitas de resultados y preferencias", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 117, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 117, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 118, Description = "Inspiradas en el funcionamiento de las neuronas biológicas, están compuestas por una multitud de procesadores paralelos interconectados, cada uno de los cuales es capaz de efectuar solo un pequeño número de operaciones simples y transmitir sus resultados a sus vecinos.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 119, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 119, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 120, Description = "Manipulación de datos completos sin ruido", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 120, Description = "Lectura de datos precisos y no contradictorios", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 120, Description = "Manipulación de datos incompletos e imprecisos", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 121, Description = "Modelación de sistemas complejos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 121, Description = "Reconocimiento de patrones", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 121, Description = "Explicación del razonamiento llevado a cabo", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 122, Description = "Se trata de una generalización de la lógica tradicional que no utiliza solo dos variables antagónicas como “negativo” o “positivo”, sino que puede manipular valores intermedios como “muy negativo, medio negativo, poco negativo, aproximadamente cero, poco positivo” etc. Se trata, en definitiva de una forma de razonamiento que permite incorporar a la maquina esquemas de pensamientos típicamente humanos.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 123, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 123, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 124, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 124, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 125, Description = "Son algoritmos matemáticos eficientes que se inspiran en los mecanismos de la evolución biológica propuestos por Darwin. Has producido excelentes soluciones en problemas complejos de optimización que poseen un gran número de parámetros.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 126, Description = "Evolucionar a partir de una población inicial de soluciones para un determinado problema, intentando producir nuevas generaciones de soluciones que sean mejores que las anteriores.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 127, Description = "Control y optimización en la distribución de energía y tráfico de datos", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 127, Description = "Sistemas de aprendizaje y redes neuronales", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 127, Description = "Minería de datos y lógica difusa", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 128, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 128, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 129, Description = "Estudia los mecanismos de control que permiten a un ente mecánico moverse en un medio físico y/o manipular elementos físicos con cierto grado de autonomía.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 130, Description = "Robótica", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 130, Description = "Algoritmos genéticos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 130, Description = "Sistemas expertos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 131, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 131, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 132, Description = "Confiabilidad, alto desempeño y tiempo de respuesta adecuado", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 132, Description = "Que sea comprensible y de alta disponibilidad", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 132, Description = "Heterogéneo y Simple", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 133, Description = "Su implementación", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 133, Description = "Su base de conocimiento", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 133, Description = "Su tiempo de respuesta", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 134, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 134, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 135, Description = "Contiene el conocimiento de los hechos y de las experiencia de los expertos en un dominio determinado.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 136, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 136, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 137, Description = "Dar a conocer el funcionamiento del sistema experto en uso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 137, Description = "Simplificar el conocimiento proporcionado por un experto", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 137, Description = "Explicar al usuario la estrategia de solución encontrada y el porqué de las decisiones tomadas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 138, Description = "Sirve para que el usuario pueda realizar una consulta en un lenguaje lo más natural posible.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 139, Description = "Nos ofrece ayuda para la estructuración e implementación del conocimiento en la base de conocimientos.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 140, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 140, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 141, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 141, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 142, Description = "Definir el alcance del problema", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 142, Description = "Asignación de utilidades", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 142, Description = "Evaluar el programa", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 143, Description = "Introducir toda la evidencia de que se disponga", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 143, Description = "Efectuar un análisis de sensibilidad", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 143, Description = "Evaluar un programa", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 145, Description = "Los cambios en las reglas son fáciles", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 145, Description = "Necesita información completa para operar", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 145, Description = "Representa y usa datos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 144, Description = "Puede contener errores", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 144, Description = "No contiene errores", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 144, Description = "Se ejecuta paso a paso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 146, Description = "La ejecución usa heurísticas y lógica", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 146, Description = "Base de conocimiento separada del mecanismo de procesamiento", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 146, Description = "No contiene errores", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 147, Description = "Una parte del sistema la forma el módulo de explicación", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 147, Description = "El sistema sólo opera completo", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 147, Description = "Los cambios son tediosos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 148, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 148, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 149, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 149, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 150, Description = "Deducción lógica de conclusiones, manipulación de conocimientos afectados por valores de probabilidad, capaz de interpretar datos ambiguos y utilización de normas o estructuras que contengan conocimientos y experiencias de expertos especializados.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 151, Description = "Generación y prueba, análisis de medios y metas y reducción.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 152, Description = "Se utiliza para resolver problemas de identificación en donde produce una hipótesis.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 153, Description = "Son completos (producen todas las soluciones posibles), no son redundantes (Nunca comprometen la eficiencia al proponer la misma solución dos veces) y están informados (usa información que limita las posibilidades restringiendo las soluciones que proponen de acuerdo a ella).", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 154, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 154, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 155, Description = "Conjunto de procesos que describen un valor", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 155, Description = "Recorrido de árboles para dar valores", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 155, Description = "Conjunto de condiciones o valores que describen un sistema", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 156, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 156, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 157, Description = "Ilustrándolo gráficamente mediante nodos y enlaces de conexión.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 158, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 158, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 159, Description = "Nodos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 159, Description = "Claves", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 159, Description = "Punteros", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 160, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 160, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 161, Description = "La definición de un espacio con todas las soluciones posibles, los estados iniciales/finales y como moverse o ir de un estado a otro dentro del espacio del problema.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 162, Description = "Árboles, datos y nodos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 162, Description = "Punteros, menor y mayor rango, bases de datos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 162, Description = "Primero en profundidad, primero en amplitud, hill climbing", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 163, Description = "La rapidez con que se encuentra una solución y la calidad de la solución.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 164, Description = "La diferencia radica en el hecho de encontrar una solución óptima a menudo nos exige una búsqueda exhaustiva porque puede que sea el único camino para determinar si hemos o no encontrado la mejor solución.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 165, Description = "Va primero y a profundidad", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 165, Description = "Explora cualquier cambio posible hasta sus conclusiones o metas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 165, Description = "Ninguna de las anteriores", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 166, Description = "Siempre va primero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 166, Description = "Explora cualquier cambio posible hasta las conclusiones o metas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 166, Description = "Comprueba cada nodo sobre el mismo nivel antes de proceder a analizar otro en un nivel más profundo", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 167, Description = "Es un conjunto de reglas simples que habilitan que la posibilidad de que una búsqueda proceda en una dirección correcta.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 168, Description = "Escoge como próximo paso el nodo que aparezca en el lugar más cercano a la meta", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 168, Description = "Buscar diferentes caminos para llegar a la meta", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 168, Description = "Ambas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 169, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 169, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 170, Description = "Escoge como próximo paso el nodo que aparezca en el lugar más lejano a la meta", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 170, Description = "Toma el camino de menor esfuerzo", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 170, Description = "Ambas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 171, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 171, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 172, Description = "Se debe de elegir una búsqueda del primero en profundidad porque es generalmente la mejor", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 173, Description = "Poda las ramas del árbol", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 173, Description = "Elimina de la base de datos todos los nodos que llevan a la solución actual y luego intenta encontrar otra solución", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 173, Description = "Ambas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 174, Description = "Elimina el último nodo del camino de la solución actual y luego lo intenta de nuevo.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 175, Description = "Reconocer las metas y convertirlas en submetas apropiadas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 175, Description = "Quitar nodos para hacer el árbol más pequeño", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 175, Description = "Ninguna de las anteriores", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 176, Description = "Es una red semántica con enlaces especiales, llamadas ramas, las cuales en cada una se conecta con dos nodos.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 177, Description = "Conectan un nodo padre a un hijo mediante una rama y producen una lista de los hijos de un nodo dado", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 178, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 178, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 179, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 179, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 180, Description = "Estructuras", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 180, Description = "Hombres y computadoras", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 180, Description = "Ninguna de las anteriores", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 181, Description = "Convertir redes en árboles de búsqueda trazando todas las trayectorias posibles hasta que ya no se pueda extender ninguna de ellas sin crear un ciclo.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 182, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 182, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 183, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 183, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 184, Description = "Reducir el mínimo costo estimado para obtener la meta", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 184, Description = "Ampliar el mínimo costo estimado para obtener la meta", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 184, Description = "Ambas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 185, Description = "Priorizar las búsquedas que realiza", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 185, Description = "Recorre los árboles nodo por nodo", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 185, Description = "No ser óptimo además de complejo e incompleto", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 186, Description = "No realizar árboles para sus búsquedas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 186, Description = "Es óptimo y completo", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 186, Description = "Ninguna de las anteriores", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 187, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 187, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 188, Description = "Hallar la trayectoria de manera sencilla mediante tomar un hijo en cada nodo que se visita y avanzar a partir de ese hijo.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 188, Description = "Tomar varios hijos de cada nodo para hacer el recorrido pasando a través de los padres para llegar a la meta.", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 188, Description = "Comenzar desde el nodo más profundo e ir haciendo el recorrido de manera ascendente para llegar a la meta", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 189, Description = "Que puede tomar diferentes rutas para buscar la solución", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 189, Description = "No hacer la búsqueda si no encuentra un camino viable", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 189, Description = "Es la posibilidad de que se quede estancada al avanzar por una ruta equivocada", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 190, Description = "Elimina las dificultades al imponer un límite a la profundidad máxima de una ruta", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 190, Description = "Realiza el mismo proceso que la búsqueda preferente por profundidad", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 190, Description = "Ninguna de las anteriores", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 191, Description = "Hacer énfasis en representar y soportar las relaciones inferenciales del dominio, ser objetivas y razonar y obtener inferencias con falta de conocimiento.", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 191, Description = "Probar la inserción de dos fronteras con el fin de que la búsqueda llegue a la meta a través de nodos.", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 191, Description = "Ninguna de las anteriores", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 192, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 192, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 193, Description = "Los nodos representan estados y los enlaces representan transiciones entre estados", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 193, Description = "Los nodos son la representación de un árbol por el cual se realiza un recorrido", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 193, Description = "Ambas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 194, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 194, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 195, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 195, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 196, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 196, Description = "Falso", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 196, Description = "Falso", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 197, Description = "Saber cómo se dicen las cosas y la manera en las que se dicen", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 197, Description = "Establecer una correlación entre toda la señal acústica y una interpretación del significado de una señal vocal", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 197, Description = "Ambas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 198, Description = "Expresividad de las redes semánticas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 198, Description = "Comprensión del lenguaje", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 198, Description = "Implantación de redes semánticas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 199, Description = "Conocimiento declarativo, Conocimiento procedural (procedural) y Conocimiento de depuración (debugging).", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 200, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 200, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 201, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 201, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 202, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 202, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 203, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 203, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 204, Description = "Manejar la descomposición de problemas, interacción de subproblemas y representación de estados, aumentando flexibilidad y manteniendo la eficiencia.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 205, Description = "Auditoria de conocimiento.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 206, Description = "Taxonomías de conocimientos y fuentes.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 207, Description = "Es aquel que emprende la mejor acción posible en una situación dada.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 208, Description = "Los filósofos.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 209, Description = "Fueron las matemáticas.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 210, Description = "Los psicólogos.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 211, Description = "Los lingüistas.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 212, Description = "Ingeniería en computación.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 213, Description = "Es la obtención de conclusiones a partir de premisas.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 214, Description = "Contar con creencias que permiten a un agente actuar de manera racional.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 215, Description = "Las redes de creencia.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 216, Description = "Constituye una manera natural de representar la información sobre la independencia condicional.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 217, Description = "Es una representación completa de la distribución de probabilidad conjunta correspondiente a un dominio.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 218, Description = "Son de manera casual, por diagnóstico, de modo combinado o de forma intercausal.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 219, Description = "Filósofos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 219, Description = "Psicólogos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 219, Description = "Agente inteligentes", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 220, Description = "Red de creencia", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 220, Description = "Razonamiento eficiente", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 220, Description = "Tabla de probabilidad", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 221, Description = "Contar creencias", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 221, Description = "Obtención de conclusiones a partir de premisas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 221, Description = "Razonamiento adecuado", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 222, Description = "Razonamiento lógico", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 222, Description = "Obtención de conclusiones", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 222, Description = "Agente que actúa de manera racional ", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 223, Description = "Cálculo de distribución de probabilidad", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 223, Description = "Nodo de combinaciones de forma intercausal", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 223, Description = "Representación completa de la distribución de probabilidad", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 224, Description = "Confluencia de matemáticas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 224, Description = "Razonamiento del conocimiento", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 224, Description = "Objetivo de la lógica", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 225, Description = "Razonar el conocimiento", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 225, Description = "Utilizar enfoques interactivos, en los que el proceso de deducción mecanizada está guiado ", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 225, Description = "Dirigir el conocimiento", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 226, Description = "H. Putnam", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 226, Description = "Robert Kowalski", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 226, Description = "W.W. Bledsoe", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 227, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 227, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 228, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 228, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 229, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 229, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 230, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 230, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 231, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 231, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 232, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 232, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 233, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 233, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 234, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 234, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 235, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 235, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 236, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 236, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 237, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 237, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 238, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 238, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 239, Description = "Facebook", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 239, Description = "Android", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 239, Description = "NQTHM de Boyer", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 240, Description = "Robbins", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 240, Description = "Boole", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 240, Description = "Baldor", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 241, Description = "Propósito", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 241, Description = "Plan ", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 241, Description = "Resultado", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 242, Description = "Aplicación", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 242, Description = "Control ", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 242, Description = "Aprendizaje ", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 243, Description = "Prolog", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 243, Description = "Dominio homogéneo", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 243, Description = "Desarrollo de un sistema experto", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 244, Description = "La cantidad de la información y su adecuada representación", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 244, Description = "Inferencia encontrada en el camino a través de las reglas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 244, Description = "De un dominio homogéneo", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 245, Description = "Identificar el problema", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 245, Description = "Los prototipos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 245, Description = "La modularidad", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 246, Description = "Estructuración de ideas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 246, Description = "Estructuración de conocimiento", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 246, Description = "Estructuración de modelos", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 247, Description = "Aislada", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 247, Description = "Abierta", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 247, Description = "Nulo", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 248, Description = "Embebido", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 248, Description = "Aislado", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 248, Description = "Integrado", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 249, Description = "Aislado", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 249, Description = "Embebido ", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 249, Description = "Integrado", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 250, Description = "Prolog", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 250, Description = "Identificador de patrones", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 250, Description = "Inferencia deductiva", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 251, Description = "El conjunto de todas aquellas técnicas y modelos que nos permitan el procesamiento, análisis y explicación de cualquier tipo de información especial obtenida a través de imágenes digitales.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 252, Description = "Hagan de esta una herramienta capaz de detectar y ubicar objetos en el mundo real.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 253, Description = "Tamaño de la imagen", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 253, Description = "Pixeles de la imagen", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 253, Description = "Color de la imagen", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 254, Description = "La estimación basada en la correspondencia de características y los métodos directos.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 255, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 255, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 256, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 256, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 257, Description = "Un problema de búsquedas", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 257, Description = "Un problema de algoritmos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 257, Description = "Un problema de programación", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 258, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 258, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 259, Description = "Construir una máquina capaz de funcionar con altos niveles de incertidumbre.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 260, Description = "El estudio de medicina", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 260, Description = "El estudio filosófico", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 260, Description = "El estudio del lenguaje", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 261, Description = "Shakey", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 261, Description = "Elguea", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 261, Description = "Shaky", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 262, Description = "El robot tendría que tener alguna forma de conocimiento del mundo que lo rodeaba.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 263, Description = "Sistema inteligente", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 263, Description = "Sistema basado en aprendizaje", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 263, Description = "Sistema basado en conocimiento", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 264, Description = "Son aquellos que requieran meta-información y meta-proceso de información.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 265, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 265, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 266, Description = "Divide y ganaras", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 266, Description = "Divide y venceras", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 266, Description = "Paso por paso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 267, Description = "Describe las actividades, de forma abstracta, necesarias para realizar las funciones en la organización.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 268, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 268, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 269, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 269, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 270, Description = "Aconsejar a los médicos en la investigación y determinación de diagnósticos en el campo de las enfermedades infecciosas  de la sangre.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 271, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 271, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 272, Description = "Trabajar como medico", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 272, Description = "Crear circuitos micro eléctricos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 272, Description = "Producir estructuras químicas", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 273, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 273, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 274, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 274, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 275, Description = "Un sistema experto capaz de aprender a medida que funciona, que crea circuitos microeléctricos tridimensionales.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 276, Description = "Es un sistema de educación de tecnología de cómputo para niños.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 277, Description = "En FUTUREKIDS se combinan interesantes proyectos con los temas que fascinan a los niños a través de un ambiente interactivo.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 278, Description = "Jaime Carbonell", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 278, Description = "Stevens", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 278, Description = "John Seely", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 279, Description = "Por Goldstein y Carr para asesorar al estudiante en el juego lógico de computadora UNIX", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 279, Description = "Por Goldstein y Carr para asesorar al estudiante en el juego lógico de computadora Wumpus", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 279, Description = "Por Stevens y Sollin para asesorar al estudiante en el juego lógico de computadora Wumpus", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 280, Description = "Desarrollar una efectiva simulación de la solución del problema en un determinado dominio desde el punto de vista del humano.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 281, Description = "El conocimiento cualitativo", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 281, Description = "El conocimiento procedimental", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 281, Description = "El conocimiento declarativo", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 282, Description = "La base de datos, y el proceso de diagnóstico que manipula la base de datos.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 283, Description = "Ordenado y no ordenado", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 283, Description = "Jerárquico y ordenado", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 283, Description = "Errores y no errores", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 284, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 284, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 285, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 285, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 286, Description = "Contabilidad de gestión", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 286, Description = "Contabilidad de costes", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 286, Description = "Contabilidad administrativa", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 287, Description = "Contabilidad de gestión", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 287, Description = "Contabilidad financiera", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 287, Description = "Contabilidad de costes", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 288, Description = "Contabilidad de costes", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 288, Description = "Contabilidad financiera", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 288, Description = "Contabilidad de gestión", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 289, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 289, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 290, Description = "Contabilidad financiera", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 290, Description = "Contabilidad de costes", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 290, Description = "Contabilidad de gestión", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 291, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 291, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 292, Description = "Es aquella parte de la planificación empresarial que trata de los aspectos financieros de la empresa.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 293, Description = "conjunto de hechos y principios acumulados por la humanidad, o el acto, hecho o estado de conocer.", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 294, Description = "Verdadero", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 294, Description = "Falso", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 295, Description = "Toda expresión que tiene significado, que es coherente y puede ser representada", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 295, Description = "La posesión y acceso al conocimiento", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 295, Description = "El estudio de la naturaleza del conocimiento", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 296, Description = "La posesión y acceso al conocimiento", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 296, Description = "Estudio de la naturaleza del conocimiento", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 296, Description = "Conocimiento acerca de lo que se conoce", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 297, Description = "El estudio de la naturaleza del conocimiento", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 297, Description = "La posesión y acceso al conocimiento", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 297, Description = "El saber que hacer", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 298, Description = "Verdadero", IsCorrect = true });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 298, Description = "Falso", IsCorrect = false });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 299, Description = "Modelos matemáticos y esquemas basados en lógica", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 299, Description = "Modelos relacionales y esquemas basados en esquemas", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 299, Description = "Modelos relacionales y esquemas basados en lógica", IsCorrect = true });

            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 300, Description = "Para problemas médicos", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 300, Description = "Mejorar la velocidad de internet", IsCorrect = false });
            context.Answer.AddOrUpdate(new Models.Db.Answer() { QuestionId = 300, Description = "Implementación rápida de los servicios", IsCorrect = true });

        }

    }

}
