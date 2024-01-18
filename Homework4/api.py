from flask import Flask, request, jsonify
import sqlite3

DB = "Homework4\\DBProduse.db"
app = Flask("api")

@app.route("/", methods =["GET"])
def home():
    return "<h1>Welcome!</h1>"

@app.route("/add", methods =["POST"])
def add():
    #1. Ia cererea de adaugare de la utilizator
    body = request.json
    #2. Validam (este gol sau nu?)
    if body["NumeProdus"] is None:
         response = {
                "error": "NumeProdus gol."
            }
         response = response(jsonify)
         return response, 400

     #3. Conectare la DB
    connection = sqlite3.connect(DB)
    cursor = connection.cursor()

    #4. Adaugare date
    query = f"""INSERT INTO Produse (NumeProdus) VALUES ('{body['NumeProdus']}')"""
    cursor.execute(query)
    connection.commit()
    connection.close()
    #6. Returnare raspuns
    return "", 200

@app.route("/read/<IDProdus>", methods =["GET"])
def read(IDProdus):
    connection = sqlite3.connect(DB)
    cursor = connection.cursor()
    query = f"SELECT NumeProdus, PretProdus FROM Produse where IDProdus={IDProdus} "
    date = list(cursor.execute(query))
    response = {
        "NumeProdus": date[0][0],
        "PretProdus": date[0][1] 
        }
    response = jsonify(response)
    connection.close()
    return response, 200


@app.route("/update", methods = ["PUT"])
def update():
    update = request.json
    connection = sqlite3.connect(DB)
    cursor = connection.cursor()
    query = f"UPDATE Produse SET NumeProdus = '{update['NumeProdus']}', PretProdus = '{update['PretProdus']}' WHERE IDProdus = '{update['IDProdus']}'"
    cursor.execute(query)
    connection.commit() #Uitasem sa pun asta aici
    connection.close()
    
    return "", 200

@app.route("/delete", methods=["DELETE"])
def delete():
    delete = request.json
    connection = sqlite3.connect(DB)
    cursor = connection.cursor()
    query = f"DELETE FROM Produse WHERE IDProdus = {delete['IDProdus']}"
    cursor.execute(query)
    connection.commit() #Uitasem sa pun asta aici
    connection.close()
    return "", 200

if __name__ == "__main__":
    app.run(debug=False, port=8000)
