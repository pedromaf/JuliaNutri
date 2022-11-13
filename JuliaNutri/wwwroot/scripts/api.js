export class Api {
    static baseUrl = "https://localhost:7006/";
    static headers = {
        "Content-Type": "application/json",
    }

    static async sendEmailData(data) {
        const url = this.baseUrl + "subscription";
        var statusCode = 0;
        
        const response = await fetch(url, {
            method: "POST",
            headers: this.headers,
            body: data
        })
        .then(res => {
            statusCode = res.status;
            
            return res;
        })
        .then(res => res.json());

        return statusCode;
    }
}