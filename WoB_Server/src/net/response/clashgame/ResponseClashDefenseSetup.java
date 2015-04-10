/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package net.response.clashgame;

import metadata.NetworkCode;
import net.response.GameResponse;
import util.GamePacket;

/**
 *
 * @author lev
 */
public class ResponseClashDefenseSetup extends GameResponse{

    public ResponseClashDefenseSetup(){
        response_id = NetworkCode.CLASH_DEFENSE_SETUP;
    }
    
    @Override
    public byte[] getBytes() {
        GamePacket packet = new GamePacket(response_id);
        return packet.getBytes();
    }
    
}
