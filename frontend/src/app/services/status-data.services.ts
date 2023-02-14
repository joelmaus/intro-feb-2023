import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { StatusResponseModel } from "../models/status.models";

@Injectable()
export class StatusDataServicee {

    constructor(private client: HttpClient) { }

    getStatus() {
        return this.client.get<>('http://localhost:1337/status');
    }
}